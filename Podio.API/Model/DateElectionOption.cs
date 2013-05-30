using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Podio.API.Model
{
    [DataContract]
    public partial class DateElectionOption
    {
        [DataMember(Name = "date_option_id", IsRequired = false)]
        public int? DateOptionId { get; set; }


        [DataMember(Name = "start_utc", IsRequired = false)]
        public DateTime? StartUtc { get; set; }


        [DataMember(Name = "end_utc", IsRequired = false)]
        public DateTime? EndUtc { get; set; }
    }
}
