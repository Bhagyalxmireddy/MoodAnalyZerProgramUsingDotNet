using MoodAnalyZerProblem;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyseTest
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className,string constructorname,string message)
        {
            Type type = typeof(MoodAnalyser);
            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorname))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.NO_SUCH_CLASS, "class Not found");
            }
        }
        public static string InvokeAnalyseMood(string message,string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyZerProblem.MoodAnalyser");
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyZerProblem.MoodAnalyser",
                    "MoodAnalyser", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserExceptions(MoodAnalyserExceptions.ExceptionType.NO_SUCH_METHOD, "Method is not found");
            }
        }
    }
}

