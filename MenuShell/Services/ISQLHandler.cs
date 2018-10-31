using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Entities;

namespace MenuShell.Services
{
    interface ISQLHandler
    {
        void AddUserSQL(User user);
        int DeleteUserSQL(string userName);
        void ListUserSQL();
        List<User> SearchUserSQL(string userName);
        List<User> LoadUsers();
    }
}
