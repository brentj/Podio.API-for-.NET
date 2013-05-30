using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Podio.API.Model;
using Podio.API.Utils;

namespace Podio.API.Services
{
    public class UserService
    {
        private Client _client;

        public UserService(Client client)
        {
            _client = client;
        }

        /// <summary>
        /// https://developers.podio.com/doc/users/get-user-22378
        /// </summary>
        public User GetUser()
        {
            return PodioRestHelper.Request<User>(String.Format("{0}/user", Constants.PODIOAPI_BASEURL), _client.AuthInfo.AccessToken).Data;
        }

        /// <summary>
        /// https://developers.podio.com/doc/users/get-profile-22379
        /// </summary>
        public Profile GetUserProfile()
        {
            return PodioRestHelper.Request<Profile>(String.Format("{0}/user/profile/", Constants.PODIOAPI_BASEURL), _client.AuthInfo.AccessToken).Data;
        }
    }
}
