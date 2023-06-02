using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;



namespace WebDriverTask.Tests
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void BeforeTest() 
        {
            DriverInstance.GetInstance();
        }


        [TearDown]
        public void TearDown()
        {
            TakeScreenshotDefaultImageFormat();
            DriverInstance.CloseBrowser();
        }
        public void TakeScreenshotDefaultImageFormat()
        {

            if (TestContext.CurrentContext.Result.Outcome == ResultState.Error)
            {
                var screenshot = ((ITakesScreenshot)DriverInstance.GetInstance()).GetScreenshot();
                var screenshotDirectoryPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "c:\\Screenshots\\");
                if (!Directory.Exists(screenshotDirectoryPath))
                {
                    Directory.CreateDirectory(screenshotDirectoryPath);
                }
                var currentDate = DateTime.Now;
                var filePath = $"{screenshotDirectoryPath}{TestContext.CurrentContext.Test.Name}_{currentDate.ToString("yyyy.MM.dd-HH.mm.ss")}.png";
                screenshot.SaveAsFile(filePath);
                TestContext.AddTestAttachment(filePath);
            }
        }
    }
}
