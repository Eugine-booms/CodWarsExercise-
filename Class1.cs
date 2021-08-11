using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public static class Kata
    {
        public static int recurs = 0;
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 98) 
                return 0;
            bool a = FollowedByAllZeros(number);
            bool b = EveryDigitIsTheSameNumber(number);
            bool c = AreSequentialIncementing(number);
            bool d = AreSequentialDecrimentind(number);
            bool e = AreAPalindrome(number);
            bool f = IsAwesome(number, awesomePhrases);
            bool g = IsInterestingInNextThoMiles(number+1, awesomePhrases, 2);
            return a || b || c || d || e || f ? 2 : g ? 1:0;

        }
        internal static bool EveryDigitIsTheSameNumber(int number)
        {
            if (number < 100) return false;
            return number.ToString().All(x => x == number.ToString()[0]);
        }
        internal static bool FollowedByAllZeros(int number)
        {
            return number.ToString().Skip(1).All(x => x == '0');
        }
        internal static bool AreSequentialIncementing(int number)
        {
            var temp = number.ToString().Select(x => x - 48).ToArray();
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if ((temp[i] + 1) % 10 != temp[i + 1] % 10) return false;
            }
            return true;
        }
        internal static bool AreSequentialDecrimentind(int number)
        {
            if (number < 100) return false;
            var temp = number.ToString().Select(x => x - 48).ToArray();
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (temp[i + 1] < 0) return false;
                if (temp[i] != temp[i + 1] + 1) return false;
            }
            return true;
        }
        internal static bool AreAPalindrome(int number)
        {
            if (number < 100) return false;
            return number.ToString().Equals(new string(number.ToString().ToCharArray().Reverse().ToArray()));
        }

        internal static bool IsAwesome(int number, List<int> awesomePhrases)
        {
            return awesomePhrases.Any(x => x == number);
        }
        internal static bool IsInterestingInNextThoMiles(int number, List<int> awesomePhrases, int level )
        {
            bool a = FollowedByAllZeros(number);
            bool b = EveryDigitIsTheSameNumber(number);
            bool c = AreSequentialIncementing(number);
            bool d = AreSequentialDecrimentind(number);
            bool e = AreAPalindrome(number);
            bool f = IsAwesome(number, awesomePhrases);
            bool g = default;
            level--;
            if (level >0 )
            {
               g=IsInterestingInNextThoMiles(number + 1, awesomePhrases, level);
            }
            return a || b || c || d || e || f || g;
        }
     }
}