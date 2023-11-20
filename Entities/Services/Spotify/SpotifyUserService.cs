using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Services.Spotify
{
    public class SpotifyUserService : UserService
    {
        public async override Task<User> Login(Credentials credentials)
        {
            return await CredentialsRepository.CanLogin(credentials, EPlatform.Spotify);
        }

        public override async Task<User> Signup(Credentials credentials)
        {
            return await CredentialsRepository.SignUp(credentials, EPlatform.Spotify);
        }
    }
}
