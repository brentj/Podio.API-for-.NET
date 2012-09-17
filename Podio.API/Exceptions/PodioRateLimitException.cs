﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podio.API.Exceptions
{
    public class PodioRateLimitException : Exception
    {
        public PodioRateLimitException()
            : base("Podio says no sir - thou cannot do shit for some time")
        {
           
        }
    }
}
