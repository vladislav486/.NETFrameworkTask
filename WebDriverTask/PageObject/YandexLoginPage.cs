using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class YandexLoginPage
    {
        public IWebElement UsernameField => DriverInstance.GetInstance().FindElement(By.XPath("//input[@autocomplete='username']"));
        public IWebElement SubmitUsernameButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement PasswordField => DriverInstance.GetInstance().FindElement(By.XPath("//input[contains(@data-t,'passwd')]"));
        public IWebElement LoginButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@type='submit']"));

    }
}
