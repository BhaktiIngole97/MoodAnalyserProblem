using MoodAnalyserProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad() // this method is used to check whether the expected mood and actual mood match or not
        {
            string expected = "SAD";
            string message = "I am in sad mood.";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message); //created object and passed the message to MoodAnalyser Constructor
            string mood = moodAnalyser.AnalyseMood(); //the value return from AnalyseMood method is stored in mood
            Assert.AreEqual(expected, mood); // checking whether both values are equal or not
        }

        [TestMethod]
        public void GivenMoodHappyShouldReturnHappy() // this method is for invalid mood like null value
        {
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

        }

        [TestMethod]
        public void GivenNullMoodShouldThrowMoodAnalyseException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmptyMoodShouldThrowMoodAnalyseException()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
    }
}



