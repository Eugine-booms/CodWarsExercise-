using System.Collections.Generic;
using System.Linq;

namespace Delegates.Observers.Exercise.TakeATenMinuteWalk
{
    public class Kata
    {
        private static Dictionary<string, int> veight = new Dictionary<string, int> { {"n",1}, {"s", -1}, {"w",2},{"e",-2 } };
        public static bool IsValidWalk(string[] walk)
        {
           
            return walk.Select(x => veight[x]).Count()==10&&walk.Select(x => veight[x]).Sum() == 0;
            //insert brilliant code here
        }
    }
}
