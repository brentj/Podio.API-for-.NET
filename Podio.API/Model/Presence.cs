using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
    public partial class Presence
    {
        [DataMember(Name = "ref_type", IsRequired = false)]
        public long RefType { get; set; }


        [DataMember(Name="ref_id", IsRequired=false)]
        public int RefId { get; set; }


        [DataMember(Name = "user_id", IsRequired = false)]
        public int UserId { get; set; }


        [DataMember(Name = "signature", IsRequired = false)]
        public string Signature { get; set; }
    }
}
