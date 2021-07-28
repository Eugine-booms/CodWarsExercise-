using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{

    public class RomanNumerals
    {
        private const int V = 1000;

        public static string ToRoman(int n)
        {
            return "jhkhk";
        }

        public static int FromRoman(string romanNumeral)
        {
            Dictionary<char, int> romanNumbers = new Dictionary<char, int>();
            romanNumbers.Add('I', 1);
            romanNumbers.Add('V', 5);
            romanNumbers.Add('X', 10);
            romanNumbers.Add('L', 50);
            romanNumbers.Add('C', 100);
            romanNumbers.Add('D', 500);
            romanNumbers.Add('M', 1000);
            int g = romanNumbers['I'];
            return romanNumeral.Select(x=>romanNumbers[x]).Sum();
        }
    }
}