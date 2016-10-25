using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqExample.Data.Stub;

namespace MoqExample
{
    /// <summary>
    /// This class contains unit tests that
    /// test the methods of a specific IQuizRepository
    /// interface implementation
    /// </summary>
    [TestClass]
    public class QuizRepositoryStubFixture : QuizTestBase
    {
        #region "private fields"
        
        private IQuizRepository _QuizRepository;
        private IQuizDataAccess _QuizSqlDataAccess;
        private int _IdCounter;
        private QuizSqlDataAccessStub _DataAccessStub;

        #endregion

        /// <summary>
        /// Initialize all test dependencies
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _IdCounter = 1;
            _QuizRepository = _PrepareQuizRepositoryForTesting();
        }

        #region "unit tests"

        [TestMethod]
        public void When_Calling_GetById_Then_Return_A_Quiz_With_Stub()
        {
            Assert.IsNotNull(_QuizRepository, "The QuizRepository is null.");

            var quiz = _QuizRepository.GetById(1);

            Assert.IsNotNull(quiz, "QuizRepository.GetById returned null.");
            Assert.AreEqual(1, quiz.Id, "The id should be 1.");
        }

        #endregion

        #region "private helper methods"

        /// <summary>
        /// This method will create an instance of an
        /// IQuizRepository implementation. 
        /// </summary>
        /// <returns>
        /// A reference to an IQuizRepository 
        /// implementation.
        /// </returns>
        private IQuizRepository _PrepareQuizRepositoryForTesting()
        {
            var dataAccessStub = _GetQuizDataAccessStub();

            //Inject the dependency via constructor injection
            _QuizRepository = new QuizRepository(dataAccessStub);

            return _QuizRepository;
        }

        private IQuizDataAccess _GetQuizDataAccessStub()
        {
            return new QuizSqlDataAccessStub();
        }

        #endregion
    }
}
