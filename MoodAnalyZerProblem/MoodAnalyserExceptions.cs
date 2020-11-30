using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyZerProblem
{
    /// <summary>
    /// Initializes the MoodanalyserException Class
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MoodAnalyserExceptions : Exception
    {
        /// <summary>
        /// Creating the CustomException types
        /// </summary>
        public enum ExceptionType
        {
            ENTER_NULL, ENTERED_EMPTY,NO_SUCH_CLASS,NO_SUCH_METHOD
        }
        /// <summary>
        /// The entered empty
        /// </summary>
        private ExceptionType Entered_EMPTY;
        private string messsage;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserExceptions"/> class.
        /// </summary>
        /// <param name="Entered_EMPTY">The entered empty.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyserExceptions(ExceptionType Entered_EMPTY, string message) : base(message)
        {
            this.Entered_EMPTY = Entered_EMPTY;
            this.messsage = message;
        }
    }
}
