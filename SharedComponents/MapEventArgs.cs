﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedComponents
{
    public class MapEventArgs
    {
        public static MapEventArgs Empty { get; } = new MapEventArgs();
    }
}