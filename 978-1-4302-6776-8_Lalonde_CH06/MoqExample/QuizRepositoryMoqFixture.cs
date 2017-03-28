using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QuizIt.Domain;

namespace MoqExample
{
    /// <summary>
    /// This class contains unit tests that
    /// test the methods of a specific IQuizRepository
    /// interface implementation
    /// </summary>
    [TestClass]
    public class QuizRepositoryMoqFixture : QuizTestBase
    {
        #region "private fields"
        
        private IQuizRepository _QuizRepository;
        private IQuizDataAccess _QuizSqlDataAccess;
        private int _IdCounter;
        private Mock<IQuizDataAccess> _MockingService;

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
        public void When_Calling_GetAll_Then_Return_A_List_Of_Quizes_With_Moq()
        {
            Assert.IsNotNull(_QuizRepository, "The QuizRepository is null.");

            var quizes = _QuizRepository.GetAll();

            Assert.IsNotNull(quizes, "QuizRepository.GetAll returned null.");

            var quizCount = ((List<Quiz>)quizes).Count;

            if (_MockingService == null)
                throw new NullReferenceException("Moq colaborator is null.");

            //Make sure that the method was called on
            //the mock object and that the expected
            //value was returned.
            _MockingService
                .Verify(q => q.GetAllQuizesFromDatabase());

            Assert.AreEqual(3, quizCount,
                string.Format("Expected 3. Actual count is {0}.", quizCount));
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
            _PrepareMockedQuizDataAccess();

            //Inject the dependency via constructor injection
            _QuizRepository = new QuizRepository(_QuizSqlDataAccess);

            return _QuizRepository;
        }

        private void _PrepareMockedQuizDataAccess()
        {
            //prepare the repository's db dependency using the moq framework
            _MockingService = new Mock<IQuizDataAccess>();

            var returnQuizList = PrepareTestQuizCollection();

            //Setup the mock object to return a collection of quiz objects
            //when calling the GetAllQuizesFromDatabase method
            _MockingService
                .Setup<IEnumerable<Quiz>>(q => q.GetAllQuizesFromDatabase())
                .Returns(returnQuizList);
            
            //Set the quiz sql data access to the mocked object reference
            //The IQuizDataAccess reference will return the Quiz list 
            //that we've configured above.  This allows us to test
            //the repository without depending on the database which
            //can't be relied on.
            _QuizSqlDataAccess = _MockingService.Object;
        }

        #endregion
    }
}
