using WebDriverTask.Data;
using WebDriverTask.SeleniumWebDriver;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class MailSendEmailTest : BaseTest
    {
        [Test]
        public void SendEmailToYandexUser()
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
