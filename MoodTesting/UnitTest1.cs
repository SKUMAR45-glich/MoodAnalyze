using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyze;
namespace MoodTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestforSad()
        {
            //Arrange
            MoodAnalyse moodAnalyser = new MoodAnalyse();
            string msg = "I am in Sad Mood";
            string mood = "SAD";

            //Act
            string result = moodAnalyser.AnalyseMood(msg);

            //Assert
            Assert.AreEqual(mood, result);
        }
    }
}
