using EjercicioIntegrador2_YouTify;

namespace EjercicioIntegrador2_YouTify.Services
{
    public abstract class LoginService
    {
        internal abstract Task<bool> Login(Credentials credentials);
    }
}