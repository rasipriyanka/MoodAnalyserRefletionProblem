﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//-----namespace-------//
namespace MoodAnalyserReflectionProblem
{
    public class MoodAnalyserFactory
    {
        public static string CreateMoodAnalyse(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserReflection.MoodAnalyser");
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserReflection.MoodAnalyser", "MoodAnalyser");
                MethodInfo method = type.GetMethod(methodName);
                object mood = method.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerExcep(MoodAnalyzerExcep.ExceptionType.NO_SUCH_METHOD, "Method is not found");

            }
        }
    }
}
    




