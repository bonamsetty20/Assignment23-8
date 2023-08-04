using MySharedLib;
using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp_Assignment23
{
    public class UserManagement
    {
        public void CreateUser(string username, string password)
        {
            if (DataValidator.IsPositiveNumber(username.Length))
            {
                Login.LogInfo($"Creating User: {username}");
                Console.WriteLine($"Password is: {password}");
            }
            else
            {
                Login.LogError("Invalid Username");
            }
        }
    }
}
