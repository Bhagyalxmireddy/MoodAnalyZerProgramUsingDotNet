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
            if (this.message.Contains("Sad"))
                return "SAD";
            else if (this.message.Contains("Happy"))
                return "HAPPY";
            else
                return "HAPPY";
        }
    }
}
