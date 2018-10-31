using System;
using System.Threading;
using MenuShell.Services;

namespace MenuShell.View
{
    class DeleteUserView
    {
        public void Display(string userName)
        {
            //var userHandler = new UserHandler();
            var sqlHandler = new SQLHandler();
            int result = 0;

                Console.Clear();
                Console.WriteLine("¤¤¤¤ DELETE USER ¤¤¤¤");
                Console.WriteLine("\n");

            result = sqlHandler.DeleteUserSQL(userName);
         

            if (result > 0)
            {
                Console.WriteLine("This user will now be deleted!");
                Thread.Sleep(1000);
            }

            else 
            {
                Console.WriteLine("No user match the criteria");
                Thread.Sleep(1000);
            }
        }
    }
}
