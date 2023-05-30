using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverTask.Data
{
    public static class UserService
    {
        public static UserEntity GetUser(string userName)
        {
            switch(userName){
                case "Harry":
                    {
                        return new UserEntity()
                        {
                            UserName = "charlingston@mail.ru",
                            Password = "159456Test"
                        };
                        break;
                    }
                case "Marry": 
                    {
                        return new UserEntity()
                        {
                            UserName = "m.charlingston@yandex.ru",
                            Password = "159456tesT"
                        };
                        break;
                    }
                default:
                    throw new Exception("User wasn't found");
            }
        }
    }
}
