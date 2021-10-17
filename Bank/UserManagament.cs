using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank 
{
    public delegate string DeleBank();
    class UserManagament
    {
        public static List<User> ListOfUsers = new List<User>()
        {
            new User("RavidAsus","Ravid123456",100000),
            new User("DanielLoPo","EfoDaniel2",1000),
            new User("Davidov","DeDe222",500)
        };
        public static string success()
        {
           
            return "login Successful";
        }
        public static string FailUserName()
        {
           
            return "login failed wrong Username";


        }
        public static string failPassword()
        {
          
            return "Login failed wrong password";
        }
        public static string login(string UserName, string Password)
        {
            foreach (var users in ListOfUsers)
            {
                if (users.UserName == UserName && users.Password == Password)
                {
                    SucessfulLoginEvent = success;
                    return SucessfulLoginEvent();
                }
               else if(users.UserName == UserName && users.Password != Password)
                {
                    
                    UnsucessfulLoginEvent = failPassword;
                    return UnsucessfulLoginEvent();
                }
                
            }
            UnsucessfulLoginEvent = FailUserName;
            return UnsucessfulLoginEvent();
        }

        public static event DeleBank SucessfulLoginEvent;
        public static event DeleBank UnsucessfulLoginEvent;
    }

    
}
