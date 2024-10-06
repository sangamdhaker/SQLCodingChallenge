using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSquares
{
    internal class Program
    {
        static int cubeSquare(int N)
        {
            HashSet<int> likedNumbers = new HashSet<int>();

            for (int i = 1; i * i <= N; i++)
            {
                likedNumbers.Add(i * i); 
            }

            for (int i = 1; i * i * i <= N; i++)
            {
                likedNumbers.Add(i * i * i); 
            }

            return likedNumbers.Count;
        }

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine(cubeSquare(N));
            }
        }
    }
}
