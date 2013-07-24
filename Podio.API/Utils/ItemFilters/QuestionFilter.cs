using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Podio.API.Utils.ItemFilters
{    /// <summary>
    /// A list of option ids for question fields.
    /// </summary>
    public class QuestionFilter : Collection<int?>, IPodioFilter
    {
        public QuestionFilter() { }
        public QuestionFilter(IList<int?> list)
            : base(list) { }

    }
}
