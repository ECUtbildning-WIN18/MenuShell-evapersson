using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuShell.View;
using MenuShell.Entities;
using System.Threading;

namespace MenuShell.Services //de flesta av de här metoderna används inte längre
{
    class UserHandler
    {
        ManageUserView manageUserView = new ManageUserView();

        public void AddUser(string firstName, string lastName, string userName, string password, string role, List<User> users)
        {
            users.Add(new User(firstName, lastName, userName, password, role));
        }

        public void RemoveUser(User user, List<User> users)
        {
            users.Remove(user);   
        }

        public List<User> FindUsers(string searchWord, List<User> users)
        {
            List<User> _users = null;

            _users = users.FindAll(x => x.UserName.ToLower().Contains(searchWord.ToLower()));
       
            return _users;
        }

        public void ListUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($" Name:{user.UserName}");
            }
        }


    }
}
