using Podio.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// Search dates within interval.  
    /// String values should match format of [operator][count][unit][round] without the brackets.
    /// [operator] = Either "+" or "-".  Default = "+"
    /// [count] = Relative number of units
    /// [unit] = Unit to use. Default = "d"  "d"=days, "w"=weeks, "m"=months, "y"=years
    /// [round] = If set to "r" then date will be rounded to the [unit].
    /// </summary>
    [DataContract]
    public class DateFilter :IPodioFilter
    {
        [DataMember(Name="from", IsRequired=true)]
        public string From { get; set; }

        [DataMember(Name = "to", IsRequired = true)]
        public string To { get; set; }
    }
}
