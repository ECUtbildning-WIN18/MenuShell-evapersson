using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;
using MenuShell.Services;

namespace MenuShell.View
{
    class SearchUserView
    {

        public void Display(UserHandler userHandler, List<User> users)
        {
            var deleteUser = new DeleteUserView();
            List<User> _users;
            string delete = "";
            Console.Clear();

            Console.WriteLine("¤¤¤¤ SEARCH USER ¤¤¤¤");
            Console.WriteLine("\n Type at least the first letter in the username: ");
            string searchWord = Console.ReadLine();

            _users = userHandler.FindUsers(searchWord, users);

            if (_users.Count > 0)
            {
                Console.WriteLine(" ¤¤¤¤ LIST USERS ¤¤¤¤ \n");
                Console.WriteLine("The following user/users was found!");
                userHandler.ListUsers(_users);

                Console.WriteLine("\n\n\n (D)elete?");
                Console.WriteLine("Press D will give you the opportunity to delete a user. Another key take you back to previous menu");
                delete = Console.ReadLine();

                if (delete.ToUpper() == "D")
                {
                    Console.WriteLine("\n\nWhich one of the users do you want to delete? Be careful and type exactly the right username");
                    string deleteChoice = Console.ReadLine();
                    deleteUser.Display(deleteChoice, users);
                }
            }

            else
            {
                Console.WriteLine($"No users found matching the search term {searchWord}");
                Thread.Sleep(1000);
            }
        }
    }
}
