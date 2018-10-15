using System;

namespace MenuShell.View
{
    class LogInView : ConsoleView
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string Display()
        {
            string keyInfo ="";

            do
            {
                base.Display();
                Console.WriteLine("¤¤¤¤ Welcome to Application Xtremely perfect ¤¤¤¤ \n");
                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                Username = Console.ReadLine();

                Console.Write("Password: ");
                Password = Console.ReadLine();

                Console.Write("\nIs this correct? (Y)es (N)o: ");
                keyInfo = Console.ReadLine();

            } while (keyInfo.ToUpper() != "Y");

            return keyInfo;
        }
    }
}
