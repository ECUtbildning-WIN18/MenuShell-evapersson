using System;
using System.Threading;

namespace MenuShell.View
{
    class ManageUserView
    {
        public void Display()
        {
            var addUser = new AddUserView();
            var searchUser = new SearchUserView();
      
            bool correctSelection = false;
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("¤¤¤¤ MANAGE USER ¤¤¤¤");
                Console.WriteLine("(1) Add user");
                Console.WriteLine("(2) Search user");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    choice = 0;
                }

                switch (choice)
                {
                    case 1:
                        addUser.Display();
                        correctSelection = true;
                        break;

                    case 2:
                        searchUser.Display();
                        correctSelection = true;
                        break;

                    default:
                        Console.WriteLine("You can only choose by numbers 1-2");
                        Thread.Sleep(1000);
                        correctSelection = false;
                        break;
                }
            }
            while (correctSelection == false);
        }
    }
}
