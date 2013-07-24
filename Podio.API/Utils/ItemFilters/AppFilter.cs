using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// List of app ids to match.  null value matches items with no app reference.
    /// </summary>
    public class AppFilter : Collection<int?>, IPodioFilter
    {
        public AppFilter() { }
        public AppFilter(IList<int?> list)
            : base(list) { }
    }
}
