using System;

using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{

    public static class Kata
    {
        public static string BrainLuck(string code, string input)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(input);
            int j = 0;
            
            string result=string.Empty;
            byte[] cpu=new byte [3000];
            int brc = 0;
            for (int i = 0; i < code.Length; ++i)
            {

                if (code[i] == '>')
                    j++;
                if (code[i] == '<')
                    j--;
                if (code[i] == '+')
                    cpu[j]++;
                if (code[i] == '-')
                    cpu[j]--;
                if (code[i] == '.')
                    result += Convert.ToChar(cpu[j]);
                if (code[i] == ',')
                {
                    cpu[j] = Convert.ToByte(sb[0]);
                    sb.Remove(0, 1);

                }
                if (code[i] == '[')
                {
                    if (cpu[j] == 0)
                    {
                        ++brc;
                        while (brc > 0)
                        {
                            ++i;
                            if (code[i] == '[')
                                ++brc;
                            if (code[i] == ']')
                                --brc;
                        }
                    }
                    else
                        continue;
                }
                else if (code[i] == ']')
                {
                    if (cpu[j] == 0)
                        continue;
                    else
                    {
                        if (code[i] == ']')
                            brc++;
                        while (brc > 0)
                        {
                            --i;
                            if (code[i] == '[')
                                brc--;
                            if (code[i] == ']')
                                brc++;
                        }
                        --i;
                    }
                }
            }
            
            return result;
        }
    }
}