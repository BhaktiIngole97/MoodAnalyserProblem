using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserProblem.MoodAnalyserCustomException;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message) // created a constructor to assign the message received from UnitTest1 class
        {
            this.message = message;
        }
        public string AnalyseMood() // this method is used to analyse the mood
        {
            try// try block is used to catch any exception occured inside block
            {
                if (this.message.Equals(string.Empty)) // if message is empty then below exception is thrown
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad")) // if the message contains the word sad then this condition becomes true and returns SAD
                {
                    return "SAD";
                }
                else // if condition becomes false then it will return HAPPY
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException) // null value exception is catch and below custom exception is thrown
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}

