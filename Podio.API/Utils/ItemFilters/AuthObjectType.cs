using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podio.API.Utils.ItemFilters
{
    public sealed class AuthObjectType
    {
        private readonly string name;
        private readonly int value;

        public static readonly AuthObjectType User = new AuthObjectType(0, "user");
        public static readonly AuthObjectType App = new AuthObjectType(1, "app");

        private AuthObjectType(int value, string name)
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