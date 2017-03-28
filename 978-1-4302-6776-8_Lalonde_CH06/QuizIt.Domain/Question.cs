using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizIt.Domain
{
    /// <summary>
    /// Represents a multiple choice quiz question
    /// </summary>
    public class Question
    {
        #region "private members"
      

        #endregion
      
        #region "public properties"

        public int Id { get; set; }

        public string DisplayText { get; set; }

        public int Points { get; set; }

        public IEnumerable<Answer> Answers { get; set; }

        #endregion
      
        #region "constructor(s)"
      
        #endregion
      
        #region "public methods"
      
        #endregion
      
        #region "private helpers"
      
        #endregion
       
    }
}
