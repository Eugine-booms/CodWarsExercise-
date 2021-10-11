using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.SquareEveryDigit
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
           return int.Parse(string.Concat(n.ToString().Select(x => char.GetNumericValue(x) * char.GetNumericValue(x))));
        }
    }
}
