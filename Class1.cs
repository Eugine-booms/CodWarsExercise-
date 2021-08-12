using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    using System;

    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            int summ = 0;
            var f = intervals.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();
            List<int> a = new List<int>();
            int count = f.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count; i++)
                {
                    if (i==j) continue;
                    if (i + 1 <= f.Count && f[j].Item1 <= f[i].Item1 && f[j].Item2 >= f[i].Item2)
                    {
                        count--;
                        f.Remove(f[i]);
                        i--;
                    }
                }
            }
            foreach (var x in f)
            {
                a.Add(x.Item1);
                a.Add(x.Item2);
            }
            for (int i=1; i<a.Count;i+=2)
            {
                summ +=a[i];
                summ -= a[i-1];
                //summ = Math.Abs(summ);
                if (i + 1 < a.Count && a[i] > a[i + 1])
                    summ -= a[i] - a[i + 1];


            }
            return summ;
        }
    }

}