using System;

namespace MenuShell2.Domain.View
{
    abstract class BaseView
    {
        public string Title { get; }

        protected BaseView(string title)
        {
            Title = title;

            Console.Title = title;
        }
    }
}
