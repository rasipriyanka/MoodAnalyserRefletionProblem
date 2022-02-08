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
            string message = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            object exepected = moodAnalyser.AnalyseMood();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser", "happy");
            exepected.Equals(obj);
        }
    }
}
