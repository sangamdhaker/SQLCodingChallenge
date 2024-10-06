using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixEvaluation
{
    internal class Program
    {
        static void Main()
        {
            string S = Console.ReadLine();
            int result = prefixEvaluation(S);
            Console.WriteLine(result);
        }

        static int prefixEvaluation(string S)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = S.Length - 1; i >= 0; i--)
            {
                char c = S[i];
                if (char.IsDigit(c))
                {
                    stack.Push(c - '0');
                }
                else
                {
                    int operand1 = stack.Pop();
                    int operand2 = stack.Pop();
                    switch (c)
                    {
                        case '+':
                            stack.Push(operand1 + operand2);
                            break;
                        case '-':
                            stack.Push(operand1 - operand2);
                            break;
                        case '*':
                            stack.Push(operand1 * operand2);
                            break;
                        case '/':
                            stack.Push(operand1 / operand2);
                            break;
                    }
                }
            }
            return stack.Pop();
        }
    }
}
