using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Podio.API.Utils.ItemFilters
{    /// <summary>
    /// Number filter for progress fields.
    /// Filter values should be between 0 and 100.
    /// </summary>
    [DataContract]
    public class ProgressFilter: IPodioFilter
    {
        public ProgressFilter(int from, int to)
        {
            if (from < 0 || from > 100) { throw new ArgumentException("'from' value must be between 0 and 100"); }
            if (to < 0 || to > 100) { throw new ArgumentException("'to' value must be between 0 and 100"); }

            this.From = from;
            this.To = to;
        }

        [DataMember(Name = "from", IsRequired = true)]
        public int From { get; private set; }

        [DataMember(Name = "to", IsRequired = true)]
        public int To { get; private set; }
    }
}
