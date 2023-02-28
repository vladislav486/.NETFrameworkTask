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
    internal class YandexLoginPageSteps
    {
        public static void LoginWithUser(UserEntity user) 
        {
            var yandexLoginPage = new YandexLoginPage();
            yandexLoginPage.UsernameField.SendKeys(user.UserName);
            yandexLoginPage.SubmitUsernameButton.Click();
            yandexLoginPage.PasswordField.SendKeys(user.Password);
            yandexLoginPage.LoginButton.Click();
            DriverInstance.GetInstance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}
