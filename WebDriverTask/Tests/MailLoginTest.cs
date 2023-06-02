using WebDriverTask.Data;
using WebDriverTask.SeleniumWebDriver;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class MailLoginTest : BaseTest
    {
        [Test]
        public void MailVerifyLogin()
        {
            //Arrange
            var user = UserService.GetUser("Harry");

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
