using System;
using System.Collections.Generic;

namespace MenuShell2.Domain.View
{
    class AddUserView : BaseView
    {
        private readonly IDictionary<string, User> _users;

        public AddUserView(IDictionary<string, User> users) : base("Adding user")
        {
            _users = users;
        }

        public string Display()
        {
            bool addedNewUser = false;
            var administratorMainView = new AdministratorMainView(_users);
            do
            {
                Console.Clear();

                Console.WriteLine("# Add user\n");

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                Console.Write("Role: ");
                string role = Console.ReadLine();

                Console.WriteLine("\nIs this correct? (Y)es (N)o");

                var user = new User(username, password, role);

                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Y)
                {
                    _users.Add(user.Username, user);

                    addedNewUser = true;
                    administratorMainView.Display();
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (addedNewUser);

            return "";
        }
    }
}
