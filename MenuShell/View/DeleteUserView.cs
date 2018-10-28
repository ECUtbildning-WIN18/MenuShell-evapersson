using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;
using MenuShell.Services;

namespace MenuShell.View
{
    class DeleteUserView
    {

        public void Display(string userName, List<User> users)
        {
            var userHandler = new UserHandler();
            bool foundInList = false;

                Console.Clear();
                Console.WriteLine("¤¤¤¤ DELETE USER ¤¤¤¤");
                Console.WriteLine("\n");

            foreach (var user in users)
            {
                if (user.UserName == userName)
                {
                    userHandler.RemoveUser(user, users);
                    foundInList = true;
                    break;
                }
            }

            if (foundInList == true)
            {
                Console.WriteLine("This user will now be deleted!");
                Thread.Sleep(1000);
            }

            else 
            {
                Console.WriteLine("No user match the criteria");
                Thread.Sleep(1000);
            }
        }
    }
}
