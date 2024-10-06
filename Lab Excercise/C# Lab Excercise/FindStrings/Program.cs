using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindStrings
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            findTheString(N);
        }

        static void findTheString(int N)
        {
            char[] result = new char[N];
            for (int i = 0; i < N; i++)
            {
                result[i] = (char)('a' + (i % 3)); 
            }
            Console.WriteLine(new string(result));
        }
    }
}
