using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Podio.API.Utils.ItemFilters
{
    [JsonConverter(typeof(SimpleValueConverter))]
    public interface ISimpleValue :IPodioFilter
    {
        object Value { get; set; }
    }
}
