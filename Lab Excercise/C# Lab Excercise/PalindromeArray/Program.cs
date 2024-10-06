using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeArray
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N == 0)
            {
                Console.WriteLine(); 
                return;
            }

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            findPalindrome(arr);
        }

        static void findPalindrome(int[] arr)
        {
            
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            
            List<int> half = new List<int>();
            int middle = -1; 
            foreach (var kvp in frequency.OrderBy(kvp => kvp.Key)) 
            {
                int num = kvp.Key;
                int count = kvp.Value;

                for (int i = 0; i < count / 2; i++)
                {
                    half.Add(num);
                }

                
                if (count % 2 == 1)
                {
                    if (middle == -1 || num < middle) 
                    {
                        middle = num;
                    }
                }
            }

            List<int> result = new List<int>(half);
            if (middle != -1)
            {
                result.Add(middle); 
            }

            result.AddRange(half.AsEnumerable().Reverse());

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
