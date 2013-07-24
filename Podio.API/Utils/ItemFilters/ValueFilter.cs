using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podio.API.Utils.ItemFilters
{
    public class ValueFilter<T> : ISimpleValue where T : IConvertible
    {
        private object _value = null;
        public ValueFilter(T data)
        {
            _value = data;
        }
        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
