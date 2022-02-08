using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserReflectionProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveMoodAnalyseClassNameShouldReturnMoodAnalyseObject()
        {
            string message = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            object exepected = moodAnalyser.AnalyseMood();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser", "happy");
            exepected.Equals(obj);
        }
        [TestMethod]
        public void GivenImproperClassToThrowCustomException() //this method for to catch the custom reflection
                                                               //if the class name was different
        {
            string expected = "Class not found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalys", "MoodAnalyser", "happy");
            }
            catch (MoodAnalyzerExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        public void GivenImproperConstructerToThrowCustomException() //this method for to catch the custom reflection
                                                                     //if the constructer  name was different
        {
            string expected = "Constructer is not found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnaly", "happy");
            }
            catch (MoodAnalyzerExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}



