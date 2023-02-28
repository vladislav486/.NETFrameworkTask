using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.Tests
{
    [TestFixture]
    public class BaseTest
    {
        private DriverInstance _driver;

        [OneTimeSetUp]
        public void BeforeTest() 
        {
            _driver = new DriverInstance();
        }

        [OneTimeTearDown]
        public void AfterTest() 
        {
            DriverInstance.CloseBrowser();
        }
    }
}
