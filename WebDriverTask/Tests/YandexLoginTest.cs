using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class YandexLoginTest : BaseTest
    {
        [Test]

        public void VerifyLogin() 
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
