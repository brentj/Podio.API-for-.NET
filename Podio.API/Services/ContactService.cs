using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Podio.API.Model;
using Podio.API.Utils;
using Podio.API.Model.Enums;

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
        public Contact GetUserContact(int userId)
        {
            return PodioRestHelper.Request<Contact>(String.Format("{0}/contact/user/{1}", Constants.PODIOAPI_BASEURL, userId), _client.AuthInfo.AccessToken).Data;
        }
            
        public List<Contact> GetContacts(int? limit=null, int? offset=null, bool excludeSelf=true, IEnumerable<ContactType> contactType=null, ContactResultType resultType=null, string order="name" )
        {
            Dictionary<string, string> args = new Dictionary<string, string>(); 
            if (limit != null) { args.Add("limit", limit.ToString()); }
            if (offset != null) { args.Add("offset", offset.ToString()); }
            args.Add("exclude_self", excludeSelf.ToString());
            if (contactType != null) { args.Add("contact_type", String.Join(",", contactType.Select(ct => ct.ToString()).ToArray())); }
            if (resultType != null) { args.Add("type", resultType.ToString()); }
            if (order != null) { args.Add("order", "name"); }
            //todo: add external_id, {field}, and required filters

            return PodioRestHelper.Request<List<Contact>>(String.Format("{0}/contact/", Constants.PODIOAPI_BASEURL), _client.AuthInfo.AccessToken, args).Data; 
        }
    }
}
