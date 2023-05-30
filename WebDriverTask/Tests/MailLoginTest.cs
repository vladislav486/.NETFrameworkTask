using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class MailLoginTest : BaseTest
    {
        [Test]
        public void VerifyLogin()
        {
            //Arrange
            var user = UserService.GetUser("Marry");

            //Action
            MailHomePageSteps.GoToPage();
            MailHomePageSteps.NavigateToLoginPage();
            DriverInstance.SwitchToIFrame();
            MailLoginPageSteps.LoginWithUser(user);
            DriverInstance.SwitchToDefaultContent();

            //Assert
            MailHomePageSteps.VerifyLoginingIn();
        }

        
    }
}
