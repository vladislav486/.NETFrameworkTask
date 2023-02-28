using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;
using static WebDriverTask.PageObject.YandexBoxPage;

namespace WebDriverTask.Steps
{
    internal class YandexBoxPageSteps
    {
        public static void VerifyLoginingIn() 
        {
            var yandexBoxPage = new YandexBoxPage();
            Assert.NotNull(yandexBoxPage.UserData, "Logining in was failed");
        }

        public static EmailItem GetEmailItemBySubject(string subject)
        {
            var yandexBoxPage = new YandexBoxPage();
            DriverInstance.GetInstance().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return yandexBoxPage.EmailList.FirstOrDefault(item => item.Subject.Text.Equals(subject));
        }

    }
}
