using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// Used to filter created_by and last_edit_by item fields
    /// </summary>
    [DataContract]
    public class AuthObjectFilter :IPodioFilter
    {
        [JsonIgnore]
        public AuthObjectType AuthorType { get; set; }

        [DataMember(Name = "id", IsRequired = true)]
        public int AuthorId { get; set; }

        [DataMember(Name = "type", IsRequired = true)]
        public string AuthorString { get { return AuthorType.ToString(); } }
    }
}
