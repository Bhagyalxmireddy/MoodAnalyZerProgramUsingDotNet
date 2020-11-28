using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyZerProblem
{
    public class MoodAnalyserExceptions : Exception
    {
        public enum ExceptionType
        {
            ENTER_NULL, ENTERED_EMPTY,
            NO_SUCH_FIELD
        }
        private ExceptionType Entered_EMPTY;
        private string messsage;

        public MoodAnalyserExceptions(ExceptionType Entered_EMPTY, string message) : base(message)
        {
            this.Entered_EMPTY = Entered_EMPTY;
            this.messsage = message;
        }
    }
}
