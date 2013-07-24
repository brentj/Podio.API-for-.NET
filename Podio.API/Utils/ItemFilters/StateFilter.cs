using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// A list of valid states.  null value matches items with no state.
    /// </summary>
    public class StateFilter : Collection<string>, IPodioFilter
    {
        public StateFilter() { }
        public StateFilter(IList<string> list)
            : base(list) { }
    }
}
