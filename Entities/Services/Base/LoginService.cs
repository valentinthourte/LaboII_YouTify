using EjercicioIntegrador2_YouTify.Model;

namespace EjercicioIntegrador2_YouTify.Services.Base
{
    public abstract class LoginService
    {
        public abstract Task<User> Login(Credentials credentials);
    }
}