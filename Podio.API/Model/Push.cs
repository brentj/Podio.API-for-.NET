using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
    [DataContract]
    public partial class Push
    {

        [DataMember(Name = "timestamp", IsRequired = false)]
        public long Timestamp { get; set; }


        [DataMember(IsRequired = false, Name = "expires_in")]
        public int ExpiresIn { get; set; }


        [DataMember(Name = "channel", IsRequired = false)]
        public string Channel { get; set; }


        [DataMember(Name = "signature", IsRequired = false)]
        public string Signature { get; set; }
    }
}
