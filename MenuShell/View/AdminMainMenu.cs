using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;

namespace MenuShell.View
{
    class AdminMainMenu
    {
        public void Display(List<User> users)
        {
            var manageUser = new ManageUserView();
            int result = 0;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("¤¤¤¤ ADMIN FUNCTIONS ¤¤¤¤ \n");
                Console.WriteLine("(1) Manage users");
                Console.WriteLine("(2) Exit");
              

                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch
                {
                    result = 0;
                }

                switch (result)
                {
                    case 1:
                        manageUser.Display(users);
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
    }
}
