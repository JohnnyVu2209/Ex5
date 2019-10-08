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
            //Console.Write("please enter value of x: ");
            //String[] x = Console.ReadLine().Split(' ');
            //int n = x.Length;
            //int[] array = new int[n];
            //InputInt(x , array);
            //FindMaxMin(array);
            //String Nhap = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("this is the result when processed: {0}", ChangeToUpperOrLowerCase(Nhap)); 
            Draw(20);
         
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
        static String ChangeToUpperOrLowerCase(String input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    output += (char)(input[i] - 'a' + 'A');
                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                    output += (char)(input[i] - 'A' + 'a');
                else
                    output += input[i];
            }
            return output;
        }
        static void Draw(int h)
        {
            char[,] cArr = new char[h, h];
            for (int i = 0; i < h; i++)
            {  
                    cArr[i, i] = 'x';
                    cArr[i, h - 1 - i] = 'x';                
                for (int j = 0; j < h; j++)
                {
                    if((i == 0 || i == h - 1) && (j == 0 || j == h - 1)  )
                    { cArr[i, j] = '+'; }
                    if ((i == 0 || i == h - 1) && (j != 0 && j != h -1))
                        cArr[i, j] = '-';
                    if ((j == 0 || j == h - 1) && (i != 0 && i != h -1))
                        cArr[i, j] = '|';
                }
            }
            

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(cArr[i,j]);
                }
                Console.WriteLine();
            }
        }
     
    }
}
