using System;
using System.Threading;
using MenuShell2.Domain.Services;

namespace MenuShell2.Domain.View
{
    class LoginView : BaseView
    {
        public LoginView(IAuthenticationService authenticationService) : base("Login")
        {
            _authenticationService = authenticationService;
        }

        public User Display()
        {
            bool loginSucceeded = false;

            User user;

            do
            {
                Console.Clear();

                Console.WriteLine("Please log in\n");

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o");

                user = _authenticationService.Authenticate(username, password);

                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    if (user == null)
                    {
                        Console.WriteLine("Wrong! Try again");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        loginSucceeded = true;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (!loginSucceeded);

            return user;
        }

        private readonly IAuthenticationService _authenticationService;
    }
}
