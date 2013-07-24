using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{    
    /// <summary>
    /// A list of valid states.  null value matches items with no state.
    /// </summary>
    public class CategoryFilter :Collection<int?>, IPodioFilter
    {
        public CategoryFilter() { }
        public CategoryFilter(IList<int?> list)
            : base(list){}
    }
}
