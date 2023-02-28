using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.SeleniumWebDriver;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class MailSendEmailTest : BaseTest
    {
        [Test]
        public void SendEmailToAnotherUser()
        {
            //Arrange
            var user = UserService.GetUser("Harry");

            //Action
            MailHomePageSteps.GoToPage();
            MailHomePageSteps.NavigateToLoginPage();
            DriverInstance.SwitchToIFrame();
            MailLoginPageSteps.LoginWithUser(user);
            DriverInstance.SwitchToDefaultContent();
            MailBoxPageSteps.SendEmail();

            //Assert
            MailBoxPageSteps.VerifyEmailIsSent();
        }
    }
}
