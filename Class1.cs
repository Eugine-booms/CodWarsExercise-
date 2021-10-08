using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{

    class Permutations
    {

        public void HtmlTags(string str)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int num = int.Parse(inputs[0]);

            for (int i = 0; i < num; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                var s = int.Parse(inputs[0]);
                Console.WriteLine("{0}", Math.Pow(s, 5));
            }
        }
    }
}