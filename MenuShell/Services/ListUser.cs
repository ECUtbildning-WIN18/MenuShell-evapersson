using System;
using System.Collections.Generic;
using MenuShell.Entities;

namespace MenuShell.Services
{
    class ListUser
    {
        public void ListAllUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($" Name:{user.FirstName} {user.LastName} Role:{user.Role}");
            }

            Console.ReadLine();
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }
    }
}
