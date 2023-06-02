using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class MailLoginPage
    {
        public IWebElement UsernameField => DriverInstance.GetInstance().FindElement(By.XPath("//input[@class='input-0-2-71']"));
        public IWebElement ProceedToPasswordButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@data-test-id='next-button']"));
        public IWebElement PasswordField => DriverInstance.GetInstance().FindElement(By.XPath("//input[@type='password']"));
        public IWebElement LoginButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@data-test-id='submit-button']"));
    }
}
