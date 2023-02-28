using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTask.SeleniumWebDriver
{
    public class DriverInstance
    {
        private static IWebDriver _driver;


        public static IWebDriver GetInstance() 
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
                _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(10));
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void SwitchToIFrame() 
        {
            var detailFrame = GetInstance().FindElements(By.XPath("//iframe[contains(@class,'popup')]"));
            GetInstance().SwitchTo().Frame(detailFrame.Last());
        }

        public static void SwitchToDefaultContent()
        {
            GetInstance().SwitchTo().DefaultContent();
        }
        public static void CloseBrowser() 
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
