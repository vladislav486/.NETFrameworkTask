using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    public class MailHomePage
    {
        public IWebElement EnterButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@data-testid='enter-mail-primary']"));
        public IWebElement UserAvatarImg => DriverInstance.GetInstance().FindElement(By.XPath("//img[contains(@alt, 'charlingston')]"));
    }
}
