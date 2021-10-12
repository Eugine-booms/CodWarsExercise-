using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.Exercise.Replace_all_dots
{
    public class Kata
    {
        public static string ReplaceDots(string str)
        {
            return str.Replace(".", "-");
        }
    }
}
