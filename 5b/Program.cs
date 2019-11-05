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
            Console.WriteLine("What you wanna do now??");
            Console.WriteLine("We have 4 optionS for you");
            Console.WriteLine("1.check if an inputted string is palindrome or not.");
            Console.WriteLine("2.input n integers on the same line (separated by space), then output the maximum and minimum numbers.");
            Console.WriteLine("3.change a line of string (inputted by user) to uppercase or lowercase");
            Console.WriteLine("4.display the following figure of height h.");
            String Ask = Convert.ToString(Console.ReadLine());   
            if(Ask == "1")
            {
                Console.WriteLine("Please input a word, phrase, number, or other sequence of characters ");
                String input = Convert.ToString(Console.ReadLine());
                IssueB1(input);
            }
            else if(Ask == "2")
            {
                Console.Write("please enter value of x: ");
                String[] x = Console.ReadLine().Split(' ');
                int n = x.Length;
                int[] array = new int[n];
                InputInt(x, array);
                FindMaxMin(array);
            }
            else if(Ask == "3")
            {
                String Nhap = Convert.ToString(Console.ReadLine());
                Console.WriteLine("this is the result when processed: {0}", ChangeToUpperOrLowerCase(Nhap));
            }
            else if(Ask == "4")
            {
                Console.WriteLine("Please insert the height of Drawing you want");
                int h = Convert.ToInt16(Console.ReadLine());
                Draw(h);
            }
            else
                Console.WriteLine("OUT OF OPTIONS!!!!");
            
         
        }
        static bool Palindrome(String input)
        {
            //String palindrome = "";
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
               // palindrome += input[i];
            //}
            //if(palindrome == input)
            //{
            //    return true;
            //}
            //return false;
             bool found = true;
             for(int i = 0;i < inputString.Length;i++)
            {
                if(inputString[i] != inputString[inputString.Length - 1 - i])
                    found = false;
            }
            return found;
            
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
                    Console.Write(cArr[i,j] + "");
                }
                Console.WriteLine();
            }
        }
     
    }
}
