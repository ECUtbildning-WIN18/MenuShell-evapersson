using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;
using MenuShell.Services;

namespace MenuShell.View
{
    class LogInView
    {
        public void Display() 
        {
            User loggedInUser = null;
            var authentication = new AuthenticationService();
            List<User> users = new List<User>();
            var userLoader = new SQLHandler();
            
            string keyInfo ="";

            do
            {
                Console.Clear();
                Console.WriteLine("¤¤¤¤ Welcome to Application Xtremely perfect ¤¤¤¤ \n");
                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("\nIs this correct? (Y)es (N)o: ");
                keyInfo = Console.ReadLine();        

                if (keyInfo.ToUpper() == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Checking your credientals...");
                    Thread.Sleep(1500);
                    users = userLoader.LoadUsers();
                    loggedInUser = authentication.Authenticate(username, password, users);

                    if (loggedInUser == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Login failed, you will be redirected to login-page");
                        Thread.Sleep(1000);
                    }
                }
            } while (keyInfo.ToUpper() != "Y" || loggedInUser == null);    
        }
    }
}
