namespace CodeWars.Exercise.Valid_Braces_6ku
{
    using System;
    using System.Collections.Generic;

    public class Brace
    {

        public static bool validBraces(String braces)
        {
            var charArray = braces.ToCharArray();
            var stack = new Stack<char>();

            foreach (var item in charArray)
            {
                switch (item)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    default:
                        
                        if (stack.Count>0&&stack.Peek() == item)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
