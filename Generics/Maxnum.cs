﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maxnum
    {
        public static float MaxIntegerNumber(float val1, float val2, float val3)
        {
            if (val1.CompareTo(val2) > 0 && val1.CompareTo(val3) > 0)
                return val1;
            if (val2.CompareTo(val1) > 0 && val2.CompareTo(val3) > 0)
                return val2;
            if (val3.CompareTo(val1) > 0 && val3.CompareTo(val2) > 0)
                return val3;
            return val2;
        }
        
    }
}
