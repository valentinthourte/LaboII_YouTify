using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using EjercicioIntegrador2_YouTify.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Services.Youtube
{
    public class YoutubeLoginService : LoginService
    {
        public async override Task<User> Login(Credentials credentials)
        {
            return await CredentialsRepository.CanLogin(credentials, EPlatform.Youtube);
        }
    }
}
