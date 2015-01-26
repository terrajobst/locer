using System;
using System.Collections;

namespace LineCounter.Logic
{
    public class IntegerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return Math.Sign(Convert.ToInt32(x) - Convert.ToInt32(y));
        }
    }
}
