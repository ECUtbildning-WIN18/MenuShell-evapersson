using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShell.View
{
    class AdminDeleteUserView : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("¤¤¤¤ DELETE USER ¤¤¤¤");
            Console.WriteLine("Choose users to delete by numbers ");
            Thread.Sleep(1000);
       
            return "";
        }
        
    }
}
