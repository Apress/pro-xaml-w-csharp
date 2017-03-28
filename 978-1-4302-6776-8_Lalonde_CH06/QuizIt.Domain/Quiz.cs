using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizIt.Domain
{
    /// <summary>
    /// Represents a quiz to use to study a specified topic
    /// </summary>
    public class Quiz
    {
        #region "private members"

        private int _Id;
        private string _Name;
        private IEnumerable<Question> _Questions;

        #endregion
      
        #region "public properties"

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        public IEnumerable<Question> Questions
        {
            get { return _Questions; }
            set { _Questions = value; }
        }

        #endregion
      
        #region "constructor(s)"
      
        #endregion
      
        #region "public methods"
      
        #endregion
      
        #region "private helpers"
      
        #endregion
    }
}

