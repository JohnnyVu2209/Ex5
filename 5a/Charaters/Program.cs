using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charaters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input character you want");
            Char c = Char.Parse(Console.ReadLine());
            //PrintAtoZ();
            //PrintZtoA();
            //UpCaseAtoZ();

            Ascii(c);
            IsUpperOrLowerCase(c);
            ChangeToUpper(c);
            ChangeToLower(c);
        }
        static void PrintAtoZ()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        static void PrintZtoA()
        {
            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        static void UpCaseAtoZ()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        static void Ascii(char c)
        {
            Console.WriteLine("ASCII Value of {0} is {1}", c, PrintAsciiValue(c));
            Console.ReadKey();
        }
        static int PrintAsciiValue(char c)
        {
            return Convert.ToInt32(c);
        }
        //static void CheckCharater(char c)
        //{
        //    if (IsUpperOrLowerCase(c) == true)
        //        Console.WriteLine("the character you give is Upper");
        //    else
        //        Console.WriteLine("the character you give is Lower");
        //}
        static void IsUpperOrLowerCase(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                if (char.IsUpper(c) == true)
                {
                    Console.WriteLine("the character you give is Upper");
                }
                else
                    Console.WriteLine("the character you give is Lower");
            }
            else
                Console.WriteLine("the character you give is Not in letter characters ");



        }
        static void ChangeToUpper(char c)
        {

            if ((c >= 'a' && c <= 'z'))
            {
                c = (char)(c - 'a' + 'A');
            }
            else if ((c >= 'A' && c <= 'Z'))
                c = c;
            else
                Console.WriteLine("the character you give is Not in letter characters ");
            Console.WriteLine("Here is UPPER charater you want: {0} ", c);
        }
        static void ChangeToLower(char c)
        {
            
            if ((c >= 'A' && c <= 'Z'))
            {
                c = (char)(c - 'A' + 'a');
            }
            else if ((c >= 'a' && c <= 'z'))
                c= c;
            else
                Console.WriteLine("the character you give is Not in letter characters ");
            Console.WriteLine("Here is Lower charater you want: {0} ", c);
        }
    }
}
