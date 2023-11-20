using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Services.Base
{
    public abstract class UserService
    {
        public abstract Task<User> Login(Credentials credentials);
        public abstract Task<User> Signup(Credentials credentials);
    }
}