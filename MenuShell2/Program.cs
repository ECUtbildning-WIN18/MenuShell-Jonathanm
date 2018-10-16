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
            var userLoader = new UserLoader();

            var users = userLoader.LoadUsers();

            var authenticationService = new AuthenticationService(userLoader);
            var loginView = new LoginView(authenticationService);
            var administratorMainView = new AdministratorMainView(users);
            var userView = new UserView();

            var validUser = loginView.Display();

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
