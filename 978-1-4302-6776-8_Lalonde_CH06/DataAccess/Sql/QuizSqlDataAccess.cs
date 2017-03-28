using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Interfaces;
using QuizIt.Domain;

namespace DataAccess.Sql
{
    /// <summary>
    /// Provides methods to load and save quiz related data to the database
    /// using ADO.NET and SQL.
    /// </summary>
    public class QuizSqlDataAccess : IQuizDataAccess
    {
        #region "private members"

        private string _DbConnectionString;
        private SqlConnection _DbConnection;
        private IDbCommand _DbCommand;

        #endregion
      
        #region "constructor(s)"

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuizSqlDataAccess()
        {
            _SetConnectionString();
        }

        #endregion
      
        #region IQuizSqlDataAccess Members

        /// <summary>
        /// Retrieve all quiz objects from the database. 
        /// </summary>
        /// <returns>A collection of quizes.</returns>
        public IEnumerable<Quiz> GetAllQuizesFromDatabase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieve all quiz objects from the database. 
        /// </summary>
        /// <param name="id">
        /// The primary key associated
        /// with the quiz to be
        /// retrieved.
        /// </param>
        /// <returns>
        /// The quiz associated with
        /// the specified id.
        /// </returns>
        public Quiz GetQuizById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("id");

            var quizDataReader = _GetQuizDataReaderById(id);

            if (quizDataReader == null)
                throw new NullReferenceException("error reading quiz data.");

            return _LoadQuizFromDataReader(quizDataReader);
        }

        #endregion
      
        #region "private helpers"

        private IDataReader _GetQuizDataReaderById(int id)
        {
            //TODO consider moving the creation of the connection and object into the using statements to gaurantee the IDisposable Dispose() method is called to close the connections
            if (_DbConnection == null)
                _DbConnection = new SqlConnection(_DbConnectionString);

            var getQuizStoredProc = "usp_GetQuizById";

            _DbCommand = new SqlCommand(getQuizStoredProc, _DbConnection);

            _DbCommand.CommandType = CommandType.StoredProcedure;

            var storedProcParam = new SqlParameter("@id", id);

            if (_DbConnection.State != ConnectionState.Open)
                _DbConnection.Open();

            var quizDataReader = _DbCommand.ExecuteReader();

            return quizDataReader;
        }

        private Quiz _LoadQuizFromDataReader(IDataReader dr)
        {
            if (dr == null)
                throw new ArgumentNullException("dr");

            var quiz = new Quiz();

            using (_DbConnection)
            {
                using (_DbCommand)
                {
                    using (dr)
                    {
                        while (dr.Read())
                        {
                            quiz.Id = (int)dr["Id"];
                            quiz.Name = (string)dr["Name"];
                            quiz.Questions = _LoadQuestionsFromDataReader(dr);
                        }

                        dr.Close();
                    }
                }

                _DbConnection.Close();
            }
            
            return quiz;
        }

        private IEnumerable<Question> _LoadQuestionsFromDataReader(IDataReader dr)
        {
            if (dr == null)
                throw new ArgumentNullException("dr");

            var questions = new List<Question>();

            while (dr.Read())
            {
                var question = new Question();
                question.Id = (int)dr["QuestionId"];
                question.DisplayText = (string)dr["QuestionDisplayText"];
                question.Points = (int)dr["QuestionPoints"];
                question.Answers = _LoadAnswersFromDataReader(dr);
                questions.Add(question);
            }

            return questions;
        }

        private IEnumerable<Answer> _LoadAnswersFromDataReader(IDataReader dr)
        {
            if (dr == null)
                throw new ArgumentNullException("dr");

            var answers = new List<Answer>();

            while (dr.Read())
            {
                var answer = new Answer();
                answer.Id = (int)dr["AnswerId"];
                answer.DisplayText = (string)dr["AnswerDisplayText"];
                answer.IsCorrect = (bool)dr["AnswerPoints"];

                answers.Add(answer);
            }

            return answers;
        }

        private void _SetConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["DbCnnString"] == null)
                throw new NullReferenceException("Null DbCnnString.");

            _DbConnectionString = 
                ConfigurationManager.ConnectionStrings["DbCnnString"].ConnectionString;

            if (string.IsNullOrEmpty(_DbConnectionString))
                throw new NullReferenceException("null connection string");

            _DbConnection = new SqlConnection(_DbConnectionString);
        }

        #endregion
    }
}