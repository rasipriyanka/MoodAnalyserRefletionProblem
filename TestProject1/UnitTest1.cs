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
    }
}

