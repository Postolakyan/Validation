using System;
using System.Collections.Generic;
using System.Linq;

namespace CardValidation
{
    internal class Program
    {

        public static void Valid(string str)
        {
            string trimmed = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
            List<long> values = new List<long>();
            long num = Convert.ToInt64(trimmed);
            long zuyg = 0;
            long kent = 0;
            long res2 = 0;

            while (num > 0)
            {
                values.Add(num%10);
                num/= 10;

            }
            values.Reverse();
            for (int i = 0; i < values.Count; i++)
            {
                if (i % 2 == 0)
                {
                    long res = 0;
                    res = values[i] * 2;
                    if (res > 9)
                    {
                        while (res > 0)
                        {
                            res2 += res % 10;
                            res/= 10;
                        }
                        zuyg += res2;
                    }
                    zuyg+= res;
                }
                else
                {
                    kent+=values[i];

                }
            }
            if ((kent + zuyg) % 10 == 0)
            {
                Console.WriteLine("The Card is valid");
            }
            else 
            {
                Console.WriteLine("The Card is NOT valid");
            }
        }
        static void Main(string[] args)
        {
            Valid("4033 1700 0422 2935");
        }
    }
}
