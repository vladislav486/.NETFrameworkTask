using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    public class MailHomePage
    {
        public IWebElement EnterButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@data-testid='enter-mail-primary']"));
        public IWebElement UserAvatarImg => DriverInstance.GetInstance().FindElement(By.XPath("//img[contains(@alt, 'charlingston')]"));
    }
}
