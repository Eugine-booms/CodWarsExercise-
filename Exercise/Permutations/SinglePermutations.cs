
using System.Linq;
using System.Collections.Generic;
namespace CodeWars.Exercise.Permutations
    {
    class Permutations
    {
        public static List<string> SinglePermutations(string s)
        {
            List<string> resultListStr = new List<string>();
            List<string> tempListStr = new List<string>();
            int r = 0;
            if (s.Length == 1 || s == string.Empty)
            {
                resultListStr.Add(s);
                return resultListStr;
            }
            if (s.Length == 2)
            {
                resultListStr.Add(s);
                resultListStr.Add(new string(new char[] { s[1], s[0] }));
                return resultListStr.Distinct().ToList(); ;
            }
            tempListStr.Clear();
            foreach (var v in s)
            {
                tempListStr.AddRange(SinglePermutations(s.Remove(r, 1)));
                r++;
                foreach (var str in tempListStr)
                {
                    resultListStr.Add(v.ToString() + str);
                }
                tempListStr.Clear();
            }
            return resultListStr.ToArray().Distinct().Where(x => x.Length == s.Length).ToList();
        }
    }
}