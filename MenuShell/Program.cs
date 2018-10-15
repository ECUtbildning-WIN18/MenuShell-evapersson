using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuShell.View;
using MenuShell.Entities;
using System.Threading;
using MenuShell.Services;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var users = new List<User>();
            
            {
                users.Add(new User(firstName: "Anna", lastName: "Anka", userName: "admin", password: "verybad", role: "Administrator"));
                users.Add (new User(firstName: "Dame", lastName: "Edna", userName: "dameedna", password: "alsobad", role: "Secretary"));
               
            };

            var loginview = new LogInView();
            var authentication = new AuthenticationService();
            var secretaryLoggedIn = new SecretaryMainMenu();
            var adminMainMenu = new AdminMainMenu();
            var adminAddUser = new AdminAddUserView();
            var manageUser = new ManageUserView();
            var addUser = new AddUser();
            var listUser = new ListUserView();
            var listAllUser = new ListUser();
            var adminDeleteUser = new AdminDeleteUserView();
            var deleteUser = new DeleteUser();
            User loggedInUser = null;
            string result;


            do
            {
                result = loginview.Display();
                if (result.ToUpper() == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Checking your credientals...");
                    Thread.Sleep(1500);
                    loggedInUser = authentication.Authenticate(loginview.Username, loginview.Password, users);

                    if (loggedInUser==null)
                    {
                        Console.Clear();
                        Console.WriteLine("Login failed, you will be redirected to login-page");
                        Thread.Sleep(1000);
                    }
                }
            }
            while (loggedInUser == null);

            do
            {
                if (loggedInUser.Role == "Secretary")
                {
                    result = secretaryLoggedIn.Display();
                    switch (result)
                    {
                        case "1":
                            listUser.Display();
                            listAllUser.ListAllUsers(users);
                            break;

                        case "2":
                            Console.WriteLine("Welcome back");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Sorry, but it seems something went wrong");
                            break;
                    }
                }
                else if (loggedInUser.Role == "Administrator")
                {
                    result = adminMainMenu.Display();
                    switch (result)
                    {
                        case "1":
                            result = manageUser.Display();
                            if (result.ToUpper() == "1")
                            {
                                adminAddUser.Display();
                                addUser.AddNewUser(adminAddUser.FirstName, adminAddUser.LastName, adminAddUser.UserName, adminAddUser.Password, adminAddUser.Role, users);
                            }
                            else if (result.ToUpper() == "2")
                            {
                                adminDeleteUser.Display();
                                deleteUser.DeleteOfUser(users);
                            }
                            break;

                        case "2":
                            loginview.Display();
                            break;

                        case "3":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Wrong input");
                            Thread.Sleep(2000);
                            break;
                    }
                }
            } while (loggedInUser != null);
        }
    }
}
