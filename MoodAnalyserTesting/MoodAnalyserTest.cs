using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            //Arrange
            string message = "Iam in Sad Mood";
            string expected = "Sad";
            //Act
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.MoodCheck();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}



