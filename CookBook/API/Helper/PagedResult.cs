﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helper
{
    public class PagedResult<T>
    {
        public long? Count { get; set; }
        public IReadOnlyList<T> Results { get; set; }
    }
}
