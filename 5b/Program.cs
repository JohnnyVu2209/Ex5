using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5b
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Convert.ToString(Console.ReadLine());
            IssueB1(input);
        }
        static bool Palindrome(String input)
        {
            String palindrome = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                palindrome += input[i];
            }
            if(palindrome == input)
            {
                return true;
            }
            return false;
        }
        static void IssueB1(String input)
        {
            if (Palindrome(input) == true)
                Console.WriteLine("An inputted String is Palindrome ");
            else
                Console.WriteLine("An inputted String is NOT Palindrome ");
        }
     
    }
}
