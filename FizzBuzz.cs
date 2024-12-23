using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leet_code
{
    public class FizzBuzz
    {
        public IList<string> FizzBuzzSolution(int n)
        {
            string[] result = new string[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else
                {
                    result[i - 1] = i.ToString();
                }
            }
            return result;
        }
    }
}
