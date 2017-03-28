using System.Collections.Generic;
using QuizIt.Domain;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// Provides a contract for classes
    /// used to read and write quiz data.
    /// </summary>
    public interface IQuizDataAccess
    {
        Quiz GetQuizById(int id);
        IEnumerable<Quiz> GetAllQuizesFromDatabase();
    }
}
