namespace MenuShell2.Domain.Services
{
    class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService(IUserLoader userLoader)
        {
            _userLoader = userLoader;
        }

        public User Authenticate(string username, string password)
        {
            User user = null;

            var users = _userLoader.LoadUsers();

            if (users.ContainsKey(username) && users[username].Password == password)
            {
                user = users[username];
            }

            return user;
        }

        private readonly IUserLoader _userLoader;
    }
}
