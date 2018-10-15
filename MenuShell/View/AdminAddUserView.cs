using System;

namespace MenuShell.View
{
    class AdminAddUserView : ConsoleView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string Display()
        {
            string result;

            do
            {
                base.Display();

                Console.WriteLine("¤¤¤¤ To create a new user account. Please add correct details ¤¤¤¤\n");

                Console.Write("Firstname: ");
                FirstName = Console.ReadLine();

                Console.Write("\nLastname: ");
                LastName = Console.ReadLine();

                Console.Write("\nUsername: ");
                UserName = Console.ReadLine();

                Console.Write("\nPassword: ");
                Password = Console.ReadLine();

                Console.Write("\nRole: ");
                Role = Console.ReadLine();

                Console.WriteLine("Is this correct (Y)es or (N)o?");
                result = Console.ReadLine();

            } while (result.ToUpper() != "Y");

            return result;
        }
    }
}
