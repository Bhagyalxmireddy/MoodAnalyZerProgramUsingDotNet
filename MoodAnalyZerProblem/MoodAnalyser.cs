using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyZerProblem
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

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
