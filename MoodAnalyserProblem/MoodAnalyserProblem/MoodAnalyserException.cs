using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY, NO_SUCH_FIELD, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT
        }
        ExceptionType type;
        public MoodAnalyserException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}

