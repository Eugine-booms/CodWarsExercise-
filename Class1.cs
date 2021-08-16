using System;
using System.Linq;
using System.Text;

namespace Solution
{

    public class CodeWars
    {
        public static string encode(string text)
        {
            var a = text.Select(x => Convert.ToString((byte) x,2)).ToArray();
            return string.Concat(string.Concat(text.Select(x => Convert.ToString(x, 2).PadLeft(8, '0'))).Select(x => x == '1' ? "111" : "000"));
        }
        public static string decode(string bits)
        {
            string decod = string.Empty;
            var charArray= bits.ToArray();
            var temp = new char[bits.Length/3];
            for (int i = 0; i < bits.Length; i=i+3)
            {
                if (charArray[i+1] == charArray[i + 2])
                    temp[i / 3] = charArray[i+2];
                else if (charArray[i]== charArray[i+1])
                {
                    temp[i / 3] = charArray[i];
                }
                else if (charArray[i] == charArray[i + 2])
                { 
                    temp[i / 3] = charArray[i]; 
                }
            }
            var bytebliat = new byte[temp.Length / 8];
            for (int i = 0; i < temp.Length; i = i + 8)
            {
                var tempArray = new char[8];
                Array.Copy(temp, i, tempArray, 0, 8);
                bytebliat[i/8] = Convert.ToByte(new string(tempArray), 2);
            }
            decod= Encoding.ASCII.GetString(bytebliat); 
            return decod;
        }
    }
}