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
            //string message = "happy";
            //MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string exepected = "happy";
            string obj = MoodAnalyseractory.CreateMoodAnalyse("happy", "AnalyseMood");
            Assert.AreEqual(exepected, obj);
        }
        [TestMethod]
        public void GivenImproperMethodToThrowCustomException() //this method for to catch the custom reflection
                                                                //if the  name was different
        {
            string expected = "method is not found";
            try
            {
                string obj = MoodAnalyseractory.CreateMoodAnalyse("happy", "AnalyseMood");
            }
            catch (MoodAnalyzerExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}





