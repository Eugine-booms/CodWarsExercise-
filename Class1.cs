using System.Linq;
namespace Solution
{
    using System.Collections.Generic;
    public class Primes
    {
        public static IEnumerable<int> Stream()
        {
            
                 var a=Enumerable.Range(2, int.MaxValue - 1).Where(number =>
                {
                    if (number == 2 || number == 3)
                        return true;
                    if (number % 2 == 0 || number % 3 == 0)
                        return false;
                    for (var i = 5; i * i <= number; i = i + 6)
                        if (number % i == 0 || number % (i + 2) == 0)
                            return false;
                    return true;
                });
            return a;

        }
    }
}