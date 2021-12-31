using NUnit.Framework;

namespace UiTests
{
    public class Tests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            Initialize();
        }

        [Test]
        public void Test1()
        {
            var textBox = AppSession.FindElementByAccessibilityId("StockNameTextBox");
            var label = AppSession.FindElementByAccessibilityId("StockNameLabel");

            string testText = Faker.Lorem.Sentence();
            textBox.SendKeys(testText);
            
            Assert.AreEqual(testText, textBox.Text);
            Assert.AreEqual(testText, label.Text);
        }
        
        [TearDown]
        public void TearDown()
        {
            Cleanup();
        }
        
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            StopWinappDriver();
        }
    }
}