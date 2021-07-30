﻿using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public static class Number
    {
      
        internal static bool EveryDigitIsTheSameNumber(int number)
        {
            throw new NotImplementedException();
        }

        internal static bool FollowedByAllZeros(int number)
        {
            throw new NotImplementedException();
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
            return awesomePhrases.Any(x => x==number);
        }
    }

    public static class Kata
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 100) return 0;
           
            //bool a = Number.FollowedByAllZeros(number);
            //bool b = Number.EveryDigitIsTheSameNumber(number);
            //bool c = Number.AreSequentialIncementing(number);
            //bool d = Number.AreSequentialDecrimentind(number);
            bool e = Number.AreAPalindrome(number);
            bool f = Number.IsAwesome(number, awesomePhrases);

            return e || f ? 2 
                : IsInteresting(number + 1, awesomePhrases) == 2 ? 1 
                : IsInteresting(number + 2, awesomePhrases) == 2 ? 1
                :0;
           
        }
    }
}