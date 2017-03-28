using System.Collections.Generic;
using DataAccess.Interfaces;
using QuizIt.Domain;

namespace MoqExample.Data.Stub
{
    /// <summary>
    /// A stub implementation of
    /// IQuizDataAccess.  This
    /// implementation is for testing
    /// only.
    /// </summary>
    public class QuizSqlDataAccessStub : QuizTestBase, IQuizDataAccess
    {
        #region IQuizDataAccess Members

        /// <summary>
        /// Return a test quiz object.
        /// </summary>
        /// <param name="id">
        /// The id of the quiz.
        /// </param>
        /// <returns>
        /// A test quiz object with the specified id.
        /// </returns>
        public Quiz GetQuizById(int id)
        {
            var quiz = this.PrepareTestQuiz();
            quiz.Id = id;

            return quiz;
        }

        /// <summary>
        /// Return a collection of test quizes
        /// </summary>
        /// <returns>
        /// A collection of quizes for unit testing.
        /// </returns>
        public IEnumerable<Quiz> GetAllQuizesFromDatabase()
        {
            return PrepareTestQuizCollection();
        }

        #endregion
    }
}
