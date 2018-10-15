using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Entities;

namespace MenuShell.View
{
    class SecretaryMainMenu : ConsoleView
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("¤¤¤¤ SECRETARY FUNCTIONS ¤¤¤¤ \n");
            Console.WriteLine("(1) List users");
            Console.WriteLine("(2) Exit");

            return Console.ReadLine();
        }
    }
}
