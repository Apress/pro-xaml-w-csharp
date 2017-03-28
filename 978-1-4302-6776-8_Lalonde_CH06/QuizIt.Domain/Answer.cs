using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizIt.Domain
{
    public class Answer
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
