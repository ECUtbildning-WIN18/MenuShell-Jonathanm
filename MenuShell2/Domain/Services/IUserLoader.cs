using System.Collections.Generic;

namespace MenuShell2.Domain.Services
{
    interface IUserLoader
    {
        IDictionary<string, User> LoadUsers();
    }
}
