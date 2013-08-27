using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podio.API.Model.Enums
{
    public sealed class ContactType
    {
        private readonly string name;
        private readonly int value;

        public static readonly ContactType User = new ContactType(0, "user");
        public static readonly ContactType Connection = new ContactType(1, "connection");
        public static readonly ContactType Space = new ContactType(1, "space");

        private ContactType(int value, string name)
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
