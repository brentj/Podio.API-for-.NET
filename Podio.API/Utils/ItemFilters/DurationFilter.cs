using System;
using System.Collections.Generic;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// Basic number filter for duration fields.
    /// Value should be non-negative, and is expressed as number of seconds.
    /// </summary>
    public class DurationFilter : NumberFilter { }
}
