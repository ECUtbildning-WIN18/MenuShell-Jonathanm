using System;
using System.Collections.Generic;

namespace MenuShell2.Domain.View
{
    class AdministratorMainView : BaseView
    {
        private readonly IDictionary<string, User> _users;

        public AdministratorMainView(IDictionary<string, User> users) : base("Administrator Main Menu")
        {
            _users = users;
        }

        public void Display()
        {
            bool isOff = false;
            var manageUserView = new ManageUserView(_users);

            do
            {
                Console.Clear();
                Console.WriteLine("(1) Manage users");
                Console.WriteLine("(2) Exit");

                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    manageUserView.Display();
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {
                    isOff = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            } while (isOff);
        }
    }
}
