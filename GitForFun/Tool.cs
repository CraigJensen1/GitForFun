using System;

namespace GitForFun
{
    public class Tool
    {
        public string AlternateCasezzz(string input)
        {
            char[] result = new char[input.Length];
            char[] resultzz = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    result[i] = char.ToUpper(input[i]);
                else
                    result[i] = char.ToLower(input[i]);
                for (int ii = 0; ii < input.Length; ii++)
                {
                    if (i % 2 == 0)
                        result[ii] = char.ToUpper(input[ii]);
                    else
                        result[ii] = char.ToLower(input[ii]);
                }
            }
            return new string(result);
        }

        public int SumOfEvenzzz(int maxNumber)
        {
            int sum = 0;
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % 2 == 0)
                    sum += i;

                sum += i;
            }
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
