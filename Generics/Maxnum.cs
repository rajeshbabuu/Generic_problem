﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maxnum
    {
        public T MaxNumber<T>(T val1, T val2, T val3) where T : IComparable
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0)
                return val1;
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0)
                return val2;
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0)
                return val3;
            return val1;
        }
        
    }
}
