using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// List of profile ids to match.  null value matches items with no contact.
    /// </summary>
    public class ContactFilter : Collection<int?>, IPodioFilter
    {
        public ContactFilter() { }
        public ContactFilter(IList<int?> list)
            : base(list) { }
    }
}
