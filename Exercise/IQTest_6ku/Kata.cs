using System;
using System.Linq;

namespace Delegates.Observers.Exercise.IQTest_6ku
{
 

    public class IQ
    {
        public static int Test(string numbers)
        {
            var res = numbers.Split(' ')
                .Select((value, ind) => new { isEven=int.Parse(value) % 2, index=ind + 1 })
                .GroupBy(x=>x.isEven)
                .First(x => x.Count() == 1)
                .First()
                .index;

            
            return res;
        }
    }
}
