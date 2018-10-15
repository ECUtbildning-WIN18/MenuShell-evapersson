using System;
using System.Threading;

namespace MenuShell.View
{
    class ListUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();

            Console.WriteLine(" ¤¤¤¤ LIST USERS ¤¤¤¤ \n");
            Console.WriteLine("You are only allowed to see the users firstname, lastname and role");
            Console.WriteLine("The list are no loading...");
            Thread.Sleep(1000);
            
            return "";
        }
    }
}
