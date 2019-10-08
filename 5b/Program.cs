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
            //String input = Convert.ToString(Console.ReadLine());
            //IssueB1(input);
            Console.Write("please enter value of x: ");
            String[] x = Console.ReadLine().Split(' ');
            int n = x.Length;
            int[] array = new int[n];
            InputInt(x , array);
            FindMaxMin(array);
         
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
        static void InputInt(String[] x , int[] array)  
        {
           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(x[i] );
            }
            Console.WriteLine("Input successful");
            
        }
        static int Max(int[] a)
        {
            int Max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (Max <= a[i])
                    Max = a[i];
            }
            return Max;
        }
        static int Min(int[] a)
        {
            int Min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (Min >= a[i])
                    Min = a[i];
            }
            return Min;
        }
        static void FindMaxMin(int[] a)
        {
            Console.WriteLine("the Max number is {0}" ,Max(a));
            Console.WriteLine("the Min number is {0}", Min(a));
        }

     
    }
}
