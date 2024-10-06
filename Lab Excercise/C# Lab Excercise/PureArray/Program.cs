using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureArray
{
    internal class Program
    {
        static void Main()
        {
            int Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pureArray(A);
            }
        }

        static void pureArray(int[] A)
        {
            int operations = 0;
            int N = A.Length;
            bool isPure = true;

            for (int i = 0; i < N / 2; i++)
            {
                if (A[i] == 0 && A[N - 1 - i] == 0)
                {
                    operations += 2;
                }
                else if (A[i] == 0 || A[N - 1 - i] == 0)
                {
                    operations++;
                }
                else if (A[i] != A[N - 1 - i])
                {
                    isPure = false;
                    break;
                }
            }

            if (N % 2 == 1 && A[N / 2] == 0)
            {
                operations++;
            }

            if (isPure)
            {
                Console.WriteLine("YES");
                Console.WriteLine(operations);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
