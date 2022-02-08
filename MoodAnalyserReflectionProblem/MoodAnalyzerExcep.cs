using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserReflectionProblem
{
    public class MoodAnalyzerExcep : Exception
    {
        public ExceptionType type;
        public enum ExceptionType //declaring the Exception
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public MoodAnalyzerExcep(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
