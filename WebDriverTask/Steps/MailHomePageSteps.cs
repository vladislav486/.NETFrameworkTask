using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;


namespace WebDriverTask.Steps
{
    internal class MailHomePageSteps
    {
        public static void NavigateToLoginPage()
        {
            var mailHomePage = new MailHomePage();
            mailHomePage.EnterButton.Click();
        }
        public static void GoToPage() 
        {
            DriverInstance.GetInstance().Navigate().GoToUrl("https://mail.ru/");
        }
        public static void VerifyLoginingIn() 
        {
            var mailLoginPage = new MailHomePage();
            Assert.IsNotNull(mailLoginPage.UserAvatarImg, "There was no user avatar found");
        }
    }
}
