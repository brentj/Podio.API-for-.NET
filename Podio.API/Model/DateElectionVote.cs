using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Podio.API.Model
{
    [DataContract]
    public partial class DateElectionVote
    {
        [DataMember(Name = "date_option_id", IsRequired = false)]
        public int? DateOptionId { get; set; }

        [DataMember(Name = "value", IsRequired = false)]
        public bool? Value { get; set; }

        [DataMember(Name = "user", IsRequired = false)]
        public Contact User { get; set; }
    }
}
