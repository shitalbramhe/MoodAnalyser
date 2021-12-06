using MoodAnalyserProblem;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "Sad";
            //Act
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void WhenGivenHappyMood_ReturnsHappyMessage()
        {

            //Arrange
            string message = "Iam in Any Mood";
            string expected = "Happy";
            //Act
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void WhenGivenNullMood_ReturnsHappyMessage()
        {

            //Arrange
            string message = "null";
            string expected = "Happy";
            //Act
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void WhenGivenNullMood_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = "null";
                MoodAnalyser mood = new MoodAnalyser(message);
                string result = mood.AnalyserMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }
        [Test]
        public void WhenGivenEMPTYMood_ShouldThrowInvalidMoodException()
        {
            try
            {
                string message = " ";
                MoodAnalyser mood = new MoodAnalyser(message);
                string result = mood.AnalyserMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}