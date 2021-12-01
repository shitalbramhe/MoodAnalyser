using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string Message;

        public MoodAnalyser(string message)
        {
            this.Message = message;
        }
        public string AnalyserMood()
        {
            if (this.Message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }

    }
}