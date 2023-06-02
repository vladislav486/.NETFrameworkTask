namespace WebDriverTask.Data
{
    public class EmailData
    {
        public static EmailEntity GetEmail() 
        {
            return new EmailEntity()
            {
                Body = "Hey Marry, it's me, Harry! I have important news to tell!",
                Subject = "Hello Marry!",
                Sender = UserService.GetUser("Harry").UserName
            };
        }
    }
}
