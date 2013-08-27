using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podio.API.Model.Enums
{
    public sealed class ContactResultType
    {
        private readonly string name;
        private readonly int value;

        public static readonly ContactResultType Mini = new ContactResultType(0, "mini");
        public static readonly ContactResultType Full = new ContactResultType(1, "full");

        private ContactResultType(int value, string name)
        {
            this.name = name;
            this.value = value;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
