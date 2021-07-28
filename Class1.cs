using System;

using System.Linq;
using System.Collections.Generic;
public class RomanNumerals
{
    public static string ToRoman(int n)
    {
        Dictionary<int, string> numbers = new Dictionary<int, string>()
                {
                {1000, "M" },
                {900, "CM" },
                {500, "D" },
                {400, "CD"  },
                {100, "C"  },
                {90,"XC"  },
                {50, "L"  },
                {40, "XL"  },
                {10, "X"  },
                {9, "IX"  },
                {5, "V"  },
                {4, "IV" },
                {1,"I" }
                };
        var startingValue = n;
        string romanValues = string.Empty;
        foreach (var arabicValues in numbers.Keys)
        {
            var div = startingValue / arabicValues;
            if (div > 0)
            {
                for (int i = 0; i < div; i++)
                    romanValues += numbers[arabicValues];
            }
            startingValue -= arabicValues * div;
        }
        return romanValues;
    }

    public static int FromRoman(string romanNumeral)
    {
        Dictionary<char, int> romanNumbers = new Dictionary<char, int>();
        romanNumbers.Add('o', -1);
        romanNumbers.Add('I', 1);
        romanNumbers.Add('V', 5);
        romanNumbers.Add('X', 10);
        romanNumbers.Add('L', 50);
        romanNumbers.Add('C', 100);
        romanNumbers.Add('D', 500);
        romanNumbers.Add('M', 1000);
        int sum = 0;
        char temp = 'o';
        foreach (char i in romanNumeral)
        {
            if (romanNumbers[i] > romanNumbers[temp] && romanNumbers[temp] != -1)
            {
                sum -= romanNumbers[temp] * 2;
            }
            sum += romanNumbers[i];
            temp = i;
        }
        return sum;
    }
}