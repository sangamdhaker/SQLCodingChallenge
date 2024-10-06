using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrSum
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(orSum(A));
        }

        static int orSum(int[] A)
        {
            int totalSum = 0;
            int totalSubsequences = 1 << A.Length;

            for (int i = 1; i < totalSubsequences; i++)
            {
                int currentOr = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        currentOr |= A[j];
                    }
                }
                totalSum += currentOr;
            }

            return totalSum;
        }
    }
}
