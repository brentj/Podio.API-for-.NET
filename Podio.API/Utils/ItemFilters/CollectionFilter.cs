using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Podio.API.Utils.ItemFilters
{
    internal class CollectionFilter<T> : Collection<T>, IPodioFilter
    {
        public CollectionFilter() { }
        public CollectionFilter(IList<T> list)
            : base(list) { }
    }
}
