using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DataAccess.Interfaces;
using QuizIt.Domain;

namespace DataAccess.Ef
{
    /// <summary>
    /// Provides methods to load and save quiz related data to the database
    /// using entity framework.
    /// </summary>
    public class QuizEfDataAccess : IQuizDataAccess
    {
        #region "private members"

        private string _DbConnectionString;
        private QuizDbContext _QuizDbContext;

        #endregion
      
        #region "constructor(s)"

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuizEfDataAccess()
        {
            if (ConfigurationManager.ConnectionStrings["DbCnnString"] == null)
                throw new NullReferenceException("connection string element not found.");

            _DbConnectionString = ConfigurationManager.ConnectionStrings["DbCnnString"].ConnectionString;

            if (string.IsNullOrEmpty(_DbConnectionString))
                throw new NullReferenceException("connection string value is null");
        }

        #endregion
      
        #region IQuizSqlDataAccess Members

        public IEnumerable<Quiz> GetAllQuizesFromDatabase()
        {
            throw new NotImplementedException();
        }

        public Quiz GetQuizById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
      
        #region "private helpers"

        #endregion
    }
}