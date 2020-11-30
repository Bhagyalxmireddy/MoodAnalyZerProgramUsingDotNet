using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyZerProblem
{
    /// <summary>
    /// MoodAnalyser Class
    /// </summary>
    public class MoodAnalyser
    {
        /// <summary>
        /// Initialiseing variables
        /// </summary>
        public string message;

        public MoodAnalyser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserExceptions">
        /// Mood should not the excepeted
        /// or
        /// Mood Shouls be Null
        /// </exception>
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.ENTERED_EMPTY, "Mood should not the excepeted");
                }
                if (this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }catch(NullReferenceException e)
            {
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.ENTER_NULL, "Mood Shouls be Null");
            }
        }
    }
}
