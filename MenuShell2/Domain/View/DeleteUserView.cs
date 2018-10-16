using System;
using System.Collections.Generic;

namespace MenuShell2.Domain.View
{
    class DeleteUserView : BaseView
    {
        private readonly IDictionary<string, User> _users;

        public DeleteUserView(IDictionary<string, User> users) : base("Deleting user")
        {
            _users = users;
        }

        public string Display()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();

                Console.WriteLine("# User list\n");

                foreach (var user in _users)
                {
                    Console.WriteLine(user.Value.Username);
                }

                Console.WriteLine("\nChoose a user to delete or press any key to cancel");
                var deleteUser = Console.ReadLine();

                if (_users.ContainsKey(deleteUser))
                {
                    _users.Remove(deleteUser);
                }
                else
                {
                    isRunning = false;
                }
            } while (isRunning);

            return "";
        }
    }
}
