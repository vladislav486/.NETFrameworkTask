using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class YandexHomePage
    {
        public IWebElement EnterButton => DriverInstance.GetInstance().FindElement(By.XPath("//a[contains(@class,'view_default')]"));

    }
}
