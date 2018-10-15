using System;
using System.Collections.Generic;
using MenuShell2.Domain;
using MenuShell2.Domain.Services;
using MenuShell2.Domain.View;

namespace MenuShell2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, User>
            {
                {
                    "test",
                    new User(username: "test",
                        password: "test",
                        role: "test")
                }
            };

            var userLoader = new UserLoader();
            var authenticationService = new AuthenticationService(userLoader);
            var loginView = new LoginView(authenticationService);
            var administratorMainView = new AdministratorMainView(users);
            var userView = new UserView();

            var validUser = loginView.Display();
            var user = userLoader.LoadUsers();

            if (validUser.Role == "Administrator")
            {
                administratorMainView.Display();
            }
            else if (validUser.Role == "User")
            {
                userView.Display();
            }
        }
    }
}
