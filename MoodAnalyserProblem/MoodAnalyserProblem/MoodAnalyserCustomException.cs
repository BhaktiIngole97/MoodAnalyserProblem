using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserCustomException : Exception // inheriting Exception
    {
        public enum ExceptionType // multiple exception type are stored
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        public readonly ExceptionType type; // type variable of ExceptionType
        public MoodAnalyserCustomException(ExceptionType Type, String message) : base(message) // constructor is used to set the exception type and message
        {
            this.type = Type;
        }
    }
}

