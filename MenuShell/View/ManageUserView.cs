using System;
using System.Collections.Generic;
using MenuShell.Entities;

namespace MenuShell.View
{
    class ManageUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("¤¤¤¤ MANAGE USER ¤¤¤¤");
            Console.WriteLine("(1) Add user");
            Console.WriteLine("(2) Delete user");
            string addOrDelete = Console.ReadLine();
   
            return addOrDelete;
        }
 
    }
}
