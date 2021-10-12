using System.Collections.Generic;
using System.Linq;

namespace CodeWarsExercise.Hamming_Numbers
{
    internal class Hamming
    {

        public static long hamming(int n)
        {
            long[] xam = new long[5000];
            long x2, x3, x5;
            int j;
            int k2 = 0, k3 = 0, k5 = 0;
            xam[0] = 1;
            for (j = 1; j < n; j++)
            {
                x2 = xam[k2] * 2;
                x3 = xam[k3] * 3;
                x5 = xam[k5] * 5;
                if (x2 <= x3 && x2 <= x5)
                {
                    xam[j] = x2;
                    k2++;
                }
                if (x3 <= x2 && x3 <= x5)
                {
                    xam[j] = x3;
                    k3++;
                }
                if (x5 <= x2 && x5 <= x3)
                {
                    xam[j] = x5;
                    k5++;
                }
            }
            return xam[n - 1];
        }
        
    }

}


