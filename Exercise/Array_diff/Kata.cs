﻿using System.Collections.Generic;
using System.Linq;

namespace Delegates.Observers.Exercise.Array_diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n=>!b.Contains(n)).ToArray();

        }
    }
}
