using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyZerProblem;

namespace MoodAnalyseTest
{
    /// <summary>
    /// Ms Testing Class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the sad mood should return sad.
        /// </summary>
        [TestMethod]
        public void givenSadMood_Should_Return_Sad()
        {
            ///Arrange
            MoodAnalyser analyser = new MoodAnalyser("i am  in Sad Mood");
            ///Act
            string mood = analyser.analyseMood();
            ///Assert
            Assert.AreEqual("SAD", mood);
        }
        /// <summary>
        /// Givens the happy mood should return happy.
        /// </summary>
        [TestMethod]
        public void givenHappyMood_Should_Return_Happy()
        {
            ///Arrange
            MoodAnalyser analyser = new MoodAnalyser("i am  in Happy Mood");
            ///Act
            string mood = analyser.analyseMood();
            ///Assert
            Assert.AreEqual("HAPPY", mood);
        }
        /// <summary>
        /// Givens the null mood should return happy.
        /// </summary>
        /// <returns>Happy</returns>
        [TestMethod]
        public void givenNullMood_Should_Return_Happy()
        {
            ///Arrange
            MoodAnalyser analyser = new MoodAnalyser("i am  in Null Mood");
            ///Act
            string mood = analyser.analyseMood();
            ///Assert
            Assert.AreEqual("HAPPY", mood);
        }
        /// <summary>
        /// Givens the null mood should return exception.
        /// </summary>
        /// <returns>Exceptions</returns>
        [TestMethod]
        public void givenNullMood_Should_Return_Exception()
        {
            try
            {
                ///Arrange
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                ///Act
                string mood = moodAnalyser.analyseMood();
            }
            catch (MoodAnalyserExceptions e)
            {
                ///Assert
                Assert.AreEqual("Mood Shouls be Null", e.Message);
            }
        }
        /// <summary>
        /// Givens the invalid mood should return exception.
        /// </summary>
        /// <returns>Exceptions</returns>
        [TestMethod]
        public void givenInvalidMood_Should_Return_Exception()
        {
            try
            {
                ///Arrange
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                ///Act
                string mood = moodAnalyser.analyseMood();
            }
            catch (MoodAnalyserExceptions e)
            {
                ///Assert
                Assert.AreEqual("Mood should not the excepeted", e.Message);
            }
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyZerProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_NotProper_ShouldReturnException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyZerApp.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual(e.Message, "class not found");
            }
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_WhenConstructorNotProper_ShouldReturnException()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyZerProblem.MoodAnalyser", "MoodAnalyse");
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual(e.Message, "Constructor not found");
            }
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject_UsingParameterizedConstructors()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyZerProblem.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_NotProper_ShouldReturnException_UsingParameterizedConstructors()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyZerApp.MoodAnalyser", "MoodAnalyser","HAPPY");
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual(e.Message, "class Not found");
            }
        }
        [TestMethod]
        public void givenMoodAnalyserClassName_WhenConstructorNotProper_ShouldReturnException_UsingParameterizedConstructors()
        {
            try
            {
                object expected = new MoodAnalyser("HAPPY");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyZerProblem.MoodAnalyser", "MoodAnalyse","HAPPY");
            }
            catch (MoodAnalyserExceptions e)
            {
                Assert.AreEqual(e.Message, "Constructor is not found");
            }
        }

    }
}
