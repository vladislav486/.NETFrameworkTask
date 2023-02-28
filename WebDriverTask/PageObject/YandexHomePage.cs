using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class YandexHomePage
    {
        public IWebElement EnterButton => DriverInstance.GetInstance().FindElement(By.XPath("//a[contains(@class,'view_default')]"));

    }
}
