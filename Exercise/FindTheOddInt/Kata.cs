using System.Linq;

namespace Delegates.Observers.Exercise.FindTheOddInt
{
    internal class Kata
    {
        public static int Find_it(int[] seq)
        {
            return seq
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .First()
                .Key;
        }

    }
}
