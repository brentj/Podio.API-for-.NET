using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Podio.API.Utils.ItemFilters
{
    [DataContract]
    public class NumberFilter :IPodioFilter
    {
        [DataMember(Name = "from", IsRequired = true)]
        public decimal From { get; set; }

        [DataMember(Name = "to", IsRequired = true)]
        public decimal To { get; set; }
    }
}
