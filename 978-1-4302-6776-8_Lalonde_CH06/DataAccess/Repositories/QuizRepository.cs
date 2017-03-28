using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using QuizIt.Domain;

namespace DataAccess.Repositories
{
    /// <summary>
    /// Represents a database agnostic abstraction used to load and save
    /// Quiz object data from the database
    /// </summary>
    public class QuizRepository : IQuizRepository
    {
        #region "private members"

        private IQuizDataAccess _QuizDataAccess;

        #endregion
      
        #region "constructor(s)"

        /// <summary>
        /// QuizRepository constructor
        /// that allows dependency injection
        /// upon instantiation.
        /// </summary>
        /// <param name="quizDataAccess">
        /// A reference to the IQuizDataAccess
        /// dependency that provides
        /// access to the database.
        /// </param>
        public QuizRepository(IQuizDataAccess quizDataAccess)
        {
            _ValidateDataAccess(quizDataAccess);

            this._QuizDataAccess = quizDataAccess;
        }

        #endregion
      
        #region "public methods"

        /// <summary>
        /// Load all quiz objects from the database.
        /// </summary>
        /// <returns>A collection of Quiz objects.</returns>
        public IEnumerable<Quiz> GetAll()
        {
            _ValidateDataAccess(_QuizDataAccess);

            var allQuizes = 
                _QuizDataAccess.GetAllQuizesFromDatabase();

            return allQuizes;
        }

        /// <summary>
        /// Load a quiz from the database.
        /// </summary>
        /// <param name="id">
        /// The id of the quiz to load.
        /// </param>
        /// <returns>
        /// The quiz associated with the specified id.
        /// </returns>
        public Quiz GetById(int id)
        {
            _ValidateDataAccess(_QuizDataAccess);

            if (id <= 0)
                throw new ArgumentOutOfRangeException("id");

            return _QuizDataAccess.GetQuizById(id);
        }

        #endregion
      
        #region "private helpers"

        private void _ValidateDataAccess(IQuizDataAccess quizDataAccess)
        {
            if (quizDataAccess == null)
                throw new ArgumentNullException("quizDataAccess");
        }

        #endregion
    }
}
