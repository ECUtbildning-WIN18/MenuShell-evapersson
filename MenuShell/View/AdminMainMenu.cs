using System;

namespace MenuShell.View
{
    class AdminMainMenu : ConsoleView
    {

        public override string Display()
        {
            base.Display();

            Console.WriteLine("¤¤¤¤ ADMIN FUNCTIONS ¤¤¤¤ \n");
            Console.WriteLine("(1) Manage users");
            Console.WriteLine("(2) Log out");
            Console.WriteLine("(3) Exit");
            string result = Console.ReadLine();

            return result; 
        }
    }
}
