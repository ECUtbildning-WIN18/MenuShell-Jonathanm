using System;

namespace MenuShell2.Domain.View
{
    internal class UserView : BaseView
    {
        public UserView() : base("User Main Menu")
        {
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("(1) User function");
            Console.WriteLine("(2) Exit");

            Console.ReadKey();
        }
    }
}