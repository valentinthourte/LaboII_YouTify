using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Services
{
    public class SpotifyLoginService : LoginService
    {
        internal async override Task<bool> Login(Credentials credentials)
        {
            return await CredentialsRepository.CanLogin(credentials, EPlatform.Spotify); 
        }
    }
}
