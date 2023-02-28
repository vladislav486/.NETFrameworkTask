using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverTask.Data;
using WebDriverTask.PageObject;
using WebDriverTask.SeleniumWebDriver;

namespace WebDriverTask.Steps
{
    internal class MailBoxPageSteps
    {
        public static void SendEmail()
        {
            var mailBoxPage = new MailBoxPage();
            var email = EmailData.GetEmail();
            var user = UserService.GetUser("Marry");
            mailBoxPage.SendEmailButton.Click();
            mailBoxPage.AdressField.SendKeys(user.UserName);
            mailBoxPage.SubjectField.SendKeys(email.Subject);
            mailBoxPage.TextField.SendKeys(email.Body);
            mailBoxPage.SendButton.Click();
        }

        public static void VerifyEmailIsSent() 
        {
            var mailBoxPage = new MailBoxPage();
            Assert.NotNull(mailBoxPage.EmailIsSentNote, "The note was nowhere to be found.");
        }
    }
}
