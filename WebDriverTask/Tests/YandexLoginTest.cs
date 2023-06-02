using WebDriverTask.Data;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class YandexLoginTest : BaseTest
    {
        [Test]

        public void YandexVerifyLogin() 
        {
            //Arrange
            var user = UserService.GetUser("Marry");

            //Action
            YandexHomePageSteps.GoToPage();
            YandexHomePageSteps.NavigateToLoginPage();
            YandexLoginPageSteps.LoginWithUser(user);

            //Assert
            YandexBoxPageSteps.VerifyLoginingIn();

        }

        
    }
}
