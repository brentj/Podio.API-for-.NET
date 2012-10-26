﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Podio.API.Model;

namespace Podio.API.Utils.ItemFields
{
    public class ProgressItemField : ItemField
    {
        public int? Value
        {
            get
            {
                if (this.HasValue("value"))
                {
                    return Convert.ToInt32((Int64)this.Values.First()["value"]);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                ensureValuesInitialized(true);
                this.Values.First()["value"] = value;
            }
        }

    }

}
