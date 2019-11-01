using System.Collections.Generic;
using System.Linq;

namespace _18_Interfaces
{
    public class Calculator : IAdvancedArithmetic
    {
        public int DivisorSumWithLinq(int n)
        {
            // APPROACH 1: With Linq
            int sum = Enumerable.Range(1, n).Where(num => n % num == 0).Sum();

            return sum;
        }

        public int DivisorSum(int n)
        {
            // APPROACH 2: Without Linq
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int answer = n % i;
                if (answer == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }

}