using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User
    {
       
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Cash { get; set; }
        public int TotalCash { get; set; }


        public User(string username, string password, int totalcash)
        {
            UserName = username;
            Password = password;
            TotalCash = totalcash;

        }
        public override string ToString()
        {
            return $"{UserName} Deposit to the bank: {Cash} Dollars"; 
        }



    }
    
}
