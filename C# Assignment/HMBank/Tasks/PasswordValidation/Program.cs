using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    internal class Program
    {
        static bool IsValidPassword(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Console.Write("Create a password for your bank account: ");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, and at least one digit.");
            }
        }
    }
}
