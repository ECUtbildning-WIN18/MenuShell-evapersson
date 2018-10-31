using System;
using MenuShell.Entities;
using MenuShell.Services;

namespace MenuShell.View
{
    class AddUserView
    {
        public void Display()
        {

            string result;
            var sqlHandler = new SQLHandler();
           

            do
            { 
                Console.Clear();

                Console.WriteLine("¤¤¤¤ To create a new user account. Please add correct details ¤¤¤¤\n");

                Console.Write("Firstname: ");
                string firstName = Console.ReadLine();

                Console.Write("\nLastname: ");
                string lastName = Console.ReadLine();

                Console.Write("\nUsername: ");
                string userName = Console.ReadLine();

                Console.Write("\nPassword: ");
                string password = Console.ReadLine();

                Console.Write("\nRole: ");
                string role = Console.ReadLine();

                Console.WriteLine("Is this correct (Y)es or (N)o?");
                result = Console.ReadLine();

                if (result.ToUpper() == "Y")
                {
                    User user = new User(firstName, lastName, userName, password, role);
                    sqlHandler.AddUserSQL(user);

                }
            } while (result.ToUpper() != "Y");

        }
    }
}
