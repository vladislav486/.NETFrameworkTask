using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;


namespace WebDriverTask.Steps
{
    internal class MailLoginPageSteps
    {
        public static void LoginWithUser(UserEntity user)
        {
            var mailLoginPage = new MailLoginPage();
            mailLoginPage.UsernameField.SendKeys(user.UserName);
            mailLoginPage.ProceedToPasswordButton.Click();
            DriverInstance.GetInstance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            mailLoginPage.PasswordField.SendKeys(user.Password);
            mailLoginPage.LoginButton.Click();
        }
    }
}
