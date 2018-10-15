using System;
using System.Collections.Generic;

namespace MenuShell2.Domain.View
{
    class ManageUserView : BaseView
    {
        private readonly IDictionary<string, User> _users;

        public ManageUserView(IDictionary<string, User> users) : base("Managing Users")
        {
            _users = users;
        }

        public void Display()
        {
            bool isOff = false;
            var addUser = new AddUserView(_users);

            do
            {
                Console.Clear();
                Console.WriteLine("(1) Add user");
                Console.WriteLine("(2) Delete user");
                Console.WriteLine("(3) Exit");

                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.D1)
                {
                    addUser.Display();
                }
                else if (keyInfo.Key == ConsoleKey.D2)
                {

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            } while (isOff);
        }
    }
}
