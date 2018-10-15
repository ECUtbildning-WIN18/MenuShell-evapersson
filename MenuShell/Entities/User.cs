namespace MenuShell.Entities
{
    class User
    {
        public string FirstName { get;}
        public string LastName { get; }
        public string UserName { get; }
        public string Password { get;}
        public string Role { get;}


        public User(string firstName, string lastName, string userName, string password, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
