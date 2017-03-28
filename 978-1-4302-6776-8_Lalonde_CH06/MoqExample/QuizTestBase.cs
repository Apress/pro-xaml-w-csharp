using System.Collections.Generic;
using QuizIt.Domain;

namespace MoqExample
{
    /// <summary>
    /// Base class for all quiz related unit testing classes
    /// </summary>
    public abstract class QuizTestBase
    {
        private int _IdCounter = 0;

        /// <summary>
        /// Create a quiz object to be used in unit tests. 
        /// </summary>
        /// <returns>A Quiz object to use for testing.</returns>
        protected virtual Quiz PrepareTestQuiz()
        {
            var testQuiz = new Quiz
            {
                Id = _IdCounter++,
                Name = string.Format("Test Quiz #{0}", _IdCounter),
            };

            testQuiz.Questions = PrepareQuizQuestions();

            return testQuiz;
        }

        /// <summary>
        /// Create a collection of quiz question objects for testing
        /// </summary>
        /// <returns>A collection of question objects.</returns>
        protected virtual IEnumerable<Question> PrepareQuizQuestions()
        {
            var quizQuestions = new List<Question>
            {
                PrepareQuestion(),
                PrepareQuestion(),
                PrepareQuestion()
            };

            return quizQuestions;
        }

        /// <summary>
        /// Create a question for testing
        /// </summary>
        /// <returns>A question object.</returns>
        protected virtual Question PrepareQuestion()
        {
            return new Question
            {
                Id = _IdCounter++,
                DisplayText = string.Format("Question # '{0}'.", _IdCounter++),
                Points = 10,
                Answers = PrepareAnswers()
            };
        }

        /// <summary>
        /// Create a collection of question answers for testing
        /// </summary>
        /// <returns>A collection of answer objects.</returns>
        protected virtual IEnumerable<Answer> PrepareAnswers()
        {
            return new List<Answer>
            {
                PrepareAnswer("Incorrect Answer 1.", false),
                PrepareAnswer("Incorrect Answer 2.", false),
                PrepareAnswer("Correct Answer.", true),
                PrepareAnswer("Incorrect Answer 3.", false)
            };
        }

        /// <summary>
        /// Create an answer for testing
        /// </summary>
        /// <returns>An answer object.</returns>
        protected Answer PrepareAnswer(string displayText, bool isCorrect)
        {
            return new Answer
            {
                Id = _IdCounter++,
                DisplayText = displayText,
                IsCorrect = isCorrect
            };
        }

        /// <summary>
        /// Create a collection of Quizes for testing
        /// </summary>
        /// <returns>A collection of quiz objects.</returns>
        protected virtual IEnumerable<Quiz> PrepareTestQuizCollection()
        {
            return new List<Quiz>
            {
                this.PrepareTestQuiz(),
                this.PrepareTestQuiz(),
                this.PrepareTestQuiz()
            };
        }
    }
}
