using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.Steps
{
    internal class YandexHomePageSteps
    {
        public static void NavigateToLoginPage()
        {
            var yandexHomePage = new YandexHomePage();
            yandexHomePage.EnterButton.Click();
            DriverInstance.GetInstance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void GoToPage() 
        {
            DriverInstance.GetInstance().Navigate().GoToUrl("https://mail.yandex.ru/");
        }
    }
}
