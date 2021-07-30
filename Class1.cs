using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
     public static class Kata
    {
        public static int recurs = 0;
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 100) 
                return 0;
            bool a = FollowedByAllZeros(number);
            bool b = EveryDigitIsTheSameNumber(number);
            bool c = AreSequentialIncementing(number);
            bool d = AreSequentialDecrimentind(number);
            bool e = AreAPalindrome(number);
            bool f = IsAwesome(number, awesomePhrases);
            bool g = IsInterestingInNextThoMiles(number, awesomePhrases, 2);
            return a || b || c || d || e || f ? 2 : g ? 1:0;

        }
        internal static bool EveryDigitIsTheSameNumber(int number)
        {
            return number.ToString().All(x => x == number.ToString()[0]);
        }
        internal static bool FollowedByAllZeros(int number)
        {
            return number.ToString().Skip(1).All(x => x == '0');
        }
        internal static bool AreSequentialIncementing(int number)
        {
            throw new NotImplementedException();
        }
        internal static bool AreSequentialDecrimentind(int number)
        {
            throw new NotImplementedException();
        }
        internal static bool AreAPalindrome(int number)
        {
            return number.ToString().Equals(new string(number.ToString().ToCharArray().Reverse().ToArray()));
        }

        internal static bool IsAwesome(int number, List<int> awesomePhrases)
        {
            return awesomePhrases.Any(x => x == number);
        }
        internal static bool IsInterestingInNextThoMiles(int number, List<int> awesomePhrases, int level )
        {
            bool a = FollowedByAllZeros(number+1);
            bool b = EveryDigitIsTheSameNumber(number+1);
            bool c = AreSequentialIncementing(number+1);
            bool d = AreSequentialDecrimentind(number+1);
            bool e = AreAPalindrome(number+1);
            bool f = IsAwesome(number+1, awesomePhrases);
            level--;
            if (level >0 )
            {
               bool g=IsInterestingInNextThoMiles(number + 2, awesomePhrases, level);
            }
            return a || b || c || d || e || f;
        }
     }
}