using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizIt.Domain;

namespace DataAccess.Interfaces
{
    /// <summary>
    /// The interface contract for a repository
    /// class used to get and save quiz objects.
    /// </summary>
    public interface IQuizRepository
    {
        /// <summary>
        /// Load all quiz objects from the database.
        /// </summary>
        /// <returns>A collection of Quiz objects.</returns>
        IEnumerable<Quiz> GetAll();

        /// <summary>
        /// Load a quiz from the database using
        /// the id specified.
        /// </summary>
        /// <param name="id">
        /// The unique id related to the
        /// quiz in which to load.
        /// </param>
        /// <returns>A quiz with the matching id.</returns>
        Quiz GetById(int id);
    }
}

