using System;

namespace MoodAnalyserReflectionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection");

            MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser", "happy");
        }
    }
}
