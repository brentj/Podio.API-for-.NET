using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Podio.API.Model;
using Podio.API.Utils;


namespace Podio.API.Services
{
    public class ContactService
    {
        private Client _client;

        /// <summary>
        /// Add a client and you can use this as a shortcut to the Podio REST API 
        /// </summary>
        public ContactService(Client client)
        {
            _client = client;
        }


        /// <summary>
        /// https://developers.podio.com/doc/contacts/get-user-contact-60514
        /// </summary>
        public User GetUser(int userId)
        {
            return PodioRestHelper.Request<User>(String.Format("{0}/contact/user/{1}", Constants.PODIOAPI_BASEURL, userId), _client.AuthInfo.AccessToken).Data;
        }
    }
}
