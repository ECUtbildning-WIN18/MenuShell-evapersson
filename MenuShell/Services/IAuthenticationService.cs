using System.Collections.Generic;
using MenuShell.Entities;

namespace MenuShell.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password, List<User> _users);  
    }
}
