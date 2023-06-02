using OpenQA.Selenium;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.PageObject
{
    internal class YandexBoxPage
    {
        public IWebElement UserData => DriverInstance.GetInstance().FindElement(By.XPath("//a[contains(@data-count,'{\"name\":\"user\"}') ]"));
        public List<EmailItem> EmailList => DriverInstance.GetInstance().FindElements(By.XPath("//div[@class='mail-MessageSnippet-Content']")).Select(i => new EmailItem(i)).ToList();

        public class EmailItem
        {
            public EmailItem(IWebElement _container)
            {
                Container = _container;
            }

            public IWebElement Container;
            public IWebElement Subject => Container.FindElement(By.XPath(".//span[contains(@class, 'Item_subject') and not(contains(@class,'js'))]/span"));
            public IWebElement Body { get; set; }
            public IWebElement Icon => Container.FindElement(By.XPath(".//span[contains(@class,'mail-Icon-Read')]"));
            public IWebElement Sender { get; set; }
        }
    }
}
