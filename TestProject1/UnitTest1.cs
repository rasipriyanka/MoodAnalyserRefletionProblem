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
            object exepected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser");
            exepected.Equals(obj);
        }
    }
}
