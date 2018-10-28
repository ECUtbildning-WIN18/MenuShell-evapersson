using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;
using MenuShell.Services;

namespace MenuShell.View
{
    class ManageUserView
    {

        public void Display(List<User> users)
        {
            var addUser = new AddUserView();
            var searchUser = new SearchUserView();
            var userHandler = new UserHandler();

            bool correctSelection = false;
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("¤¤¤¤ MANAGE USER ¤¤¤¤");
                Console.WriteLine("(1) Add user");
                Console.WriteLine("(2) Search user");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choice = 0;
                }


                switch (choice)
                {
                    case 1:
                        addUser.Display(userHandler, users);
                        correctSelection = true;
                        break;

                    case 2:
                        searchUser.Display(userHandler, users);
                        correctSelection = true;
                        break;

                    default:
                        Console.WriteLine("You can only choose by numbers 1-2");
                        Thread.Sleep(1000);
                        correctSelection = false;
                        break;
                }
            }
            while (correctSelection == false);
        }
 
    }
}
