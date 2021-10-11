namespace Delegates.Observers.Exercise.Range_Extraction
{
    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            var result = string.Empty;
            int first = args[0];
            int last = 0;
            int count = 1;

            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] == args[i - 1] + 1)
                {
                    last = args[i];
                    count++;
                }
                else
                {
                    if (count == 1)
                    {
                        result += first.ToString() + ",";
                    }
                    else if (count == 2)
                    {
                        result += first.ToString() + "," + last.ToString() + ",";
                    }
                    if (count > 2)
                    {
                        result += first.ToString() + "-" + last.ToString() + ",";
                    }

                    first = args[i];
                    count = 1;
                }
            }
            if (count == 1)
            {
                result += first.ToString() + ",";
            }
            else if (count == 2)
            {
                result += first.ToString() + "," + last.ToString() + ",";
            }
            if (count > 2)
            {
                result += first.ToString() + "-" + last.ToString() + ",";
            }
            return result.Substring(0, result.Length - 1);
        }
    }
}
