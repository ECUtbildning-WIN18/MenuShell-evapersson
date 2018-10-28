using System.Collections.Generic;
using MenuShell.View;
using MenuShell.Entities;

namespace MenuShell
{
    class Program
    {
        public static List<User> users = new List<User>()

            {
                new User(firstName: "Anna", lastName: "Anka", userName: "admin", password: "verybad", role: "Administrator"),
                new User(firstName: "Dame", lastName: "Edna", userName: "dameedna", password: "alsobad", role: "Secretary"),
            };
      

        static void Main(string[] args)
        {
            LogInView loginview = new LogInView();
            loginview.Display(users);

            
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Display(users);
        }

    }
}
