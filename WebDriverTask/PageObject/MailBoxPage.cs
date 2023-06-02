using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class MailBoxPage
    {
        public IWebElement SendEmailButton => DriverInstance.GetInstance().FindElement(By.XPath("//span[@class='compose-button__txt']"));
        public IWebElement AdressField => DriverInstance.GetInstance().FindElement(By.XPath("//input[contains(@class,'container--H9L5q') and @style]"));
        public IWebElement SubjectField => DriverInstance.GetInstance().FindElement(By.XPath("//input[@name= 'Subject']"));
        public IWebElement TextField => DriverInstance.GetInstance().FindElement(By.XPath("//div[@role='textbox']"));
        public IWebElement SendButton => DriverInstance.GetInstance().FindElement(By.XPath("//button[@data-test-id='send']"));
        public IWebElement EmailIsSentNote => DriverInstance.GetInstance().FindElement(By.XPath("//a[@class='layer__link']"));
        

        
    }
}
