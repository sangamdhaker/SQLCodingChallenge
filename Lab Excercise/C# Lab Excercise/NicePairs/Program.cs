using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicePairs
{
    internal class Program
    {
        static void Main()
        {
            string S = Console.ReadLine();
            Console.WriteLine(nicePair(S));
        }

        static int nicePair(string S)
        {
            int countA = 0;
            int nicePairs = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'a')
                {
                    countA++;
                }
                else if (S[i] == 'b')
                {
                    nicePairs += countA;
                }
            }

            return nicePairs;
        }
    }
}
