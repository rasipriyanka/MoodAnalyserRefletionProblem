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
            string obj = MoodAnalyserFactory.CreateMoodAnalyse("happy", "AnalyseMood");
            Assert.AreEqual(exepected, obj);
        }
    }
}



