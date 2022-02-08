using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserReflectionProblem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string exepected = "happy";
            string obj = MoodAnalyserFactory.CreateMoodAnalyse("happy", "AnalyseMood");
            Assert.AreEqual(exepected, obj);
        }
    }
}
