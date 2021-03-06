//--Dependencies---//
using System;
using System.Collections.Generic;
using System.Text;
//-----Namespace----//
namespace MoodAnalyserReflectionProblem
{
    public class MoodAnalyzerExcep : Exception
    {/// <summary>
     /// Custom Exception 
     /// </summary>
        public ExceptionType type;
        public enum ExceptionType 
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
