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
            //string message = null;
            object exepected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser");
            exepected.Equals(obj);
        }
        [TestMethod]
        public void GivenImproperClassToThrowCustomException() //this method for to catch the custom reflection
                                                               //if the class name was different
        {
            string expected = "Class not found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser");
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
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnaly");
            }
            catch (MoodAnalyzerExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}

