namespace MenuShell2.Domain.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
