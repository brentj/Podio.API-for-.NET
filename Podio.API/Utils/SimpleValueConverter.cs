using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Podio.API.Utils.ItemFilters;

namespace Podio.API.Utils
{
    public class SimpleValueConverter :JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ISimpleValue);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var item = (ISimpleValue)value;
            writer.WriteValue(item.Value);
            writer.Flush();
        }
    }
}
