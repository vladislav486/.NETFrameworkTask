using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.Steps;

namespace WebDriverTask.Tests
{
    internal class CheckYandexEmailReceived : BaseTest
    {
        [Test]

        public void VerifyEmailReceived()
        {
            //Arrange
            var user = UserService.GetUser("Marry");
            var email = EmailData.GetEmail();

            //Action
            YandexHomePageSteps.GoToPage();
            YandexHomePageSteps.NavigateToLoginPage();
            YandexLoginPageSteps.LoginWithUser(user);
            var emailItem = YandexBoxPageSteps.GetEmailItemBySubject(email.Subject);

            //Assert
            Assert.IsTrue(emailItem.Icon.GetAttribute("class").Contains("is-active"));
        }
    }
}
