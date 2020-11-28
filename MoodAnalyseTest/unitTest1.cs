using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyZerProblem;

namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void givenSadMood_Should_Return_Sad()
        {
            MoodAnalyser analyser = new MoodAnalyser("i am  in Sad Mood");
            string mood = analyser.analyseMood();
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void givenHappyMood_Should_Return_Happy()
        {
            MoodAnalyser analyser = new MoodAnalyser("i am  in Happy Mood");
            string mood = analyser.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void givenNullMood_Should_Return_Happy()
        {
            MoodAnalyser analyser = new MoodAnalyser("i am  in Null Mood");
            string mood = analyser.analyseMood();
            Assert.AreEqual("HAPPY", mood);
        }

    }
}
