using System.Collections.Generic;
using MenuShell.Entities;

namespace MenuShell.Services
{
    class AddUser
    {
        public void AddNewUser(string firstName, string lastName, string userName, string password, string role, List<User> users)
        {
            users.Add(new User(firstName, lastName, userName, password, role));
        }
    }
}
