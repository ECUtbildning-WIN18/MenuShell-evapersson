namespace MenuShell.Entities
{
    class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string UserName { get; set; }
        public string Password { get; }
        public string Role { get; }

        public User()
        {

        }


        public User(string firstName, string lastName, string userName, string password, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return UserName;
            
        }
    }
}
