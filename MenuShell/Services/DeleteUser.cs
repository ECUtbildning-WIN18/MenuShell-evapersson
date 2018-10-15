using System;
using System.Collections.Generic;
using System.Threading;
using MenuShell.Entities;

namespace MenuShell.Services
{
    class DeleteUser
    {
        public void DeleteOfUser(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }

            Console.WriteLine("Which one of the users do you want to delete? Choose by the numbers before user");
            int deleteChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("You will now delete this user, this handling is irreversible and you have to create the user again if this was wrong!");
            Thread.Sleep(1000);
            users.RemoveAt(deleteChoice - 1);

        }
    }
}
