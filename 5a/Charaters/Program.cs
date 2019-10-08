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
            //Console.Write('A');
            //char c = 'A';
            //Console.WriteLine(c);
            //short s = 0x41;
            //Console.WriteLine((char)s);
            //c = (char)s;
            //Console.WriteLine(c);
            //c++;
            //Console.WriteLine(c);
            Console.WriteLine("What you wanna do now??");
            Console.WriteLine("We have 5 options for you");
            Console.WriteLine("a.Print all English Alphabet letters from a to z");
            Console.WriteLine("b.Print all English Alphabet letters from z to a");
            Console.WriteLine("c.Print all English Alphabet letters from A to Z (UPPER CASE)");
            Console.WriteLine("d.Output the ASCII code of an inputted character");
            Console.WriteLine("e.Check if an inputted character is upper or lower case");
            Console.WriteLine("f.Change an inputted character to upper and lower case");

            Console.WriteLine("You choose: ");
            char choose = Convert.ToChar(Console.ReadLine());
            Char c = ' ';
            switch(choose){
                case 'a':
                    PrintAtoZ();
                    break;
                case 'b':
                    PrintZtoA();
                    break;
                case 'c':
                    UpCaseAtoZ();
                    break;
                case 'd':
                     Console.WriteLine("Please input character you want");
                     c = Char.Parse(Console.ReadLine());
                     Ascii(c);
                    break;
                case 'e':
                    Console.WriteLine("Please input character you want");
                    c = Char.Parse(Console.ReadLine());
                    IsUpperOrLowerCase(c);
                    break;
                case 'f':
                    Console.WriteLine("Please input character you want");
                    c = Char.Parse(Console.ReadLine());
                    ChangeToUpperAndLower(c);
                    break;
                default:
                    Console.WriteLine("dont have in options we give you");
                    break;
            }
       
        }
        static void PrintAtoZ()
        {
            
            //for (short i = 0; i <256 ; i++)
            //{
            //    Console.Write((char)i + " ");
            //}
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        static void PrintZtoA()
        {
            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.Write(c+ " ");
            }
            Console.WriteLine();
        }
        static void UpCaseAtoZ()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
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
        static void ChangeToUpperAndLower(char c)
        {
            if (c >= 'a' && c <= 'z')
                ChangeToUpper(c);
            if (c >= 'A' && c <= 'Z')
                ChangeToLower(c);
            else
                Console.WriteLine("cant do it");
        }
        static void ChangeToUpper(char c)
        {

            if ((c >= 'a' && c <= 'z'))
            {
                c = (char)(c - 'a' + 'A');
                Console.WriteLine("Here is UPPER charater you want: {0} ", c);
            }
            else if ((c >= 'A' && c <= 'Z'))
                Console.WriteLine("Here is UPPER charater you want: {0} ", c);
            else
                Console.WriteLine("the character you give is Not in letter characters ");
            
        }
        static void ChangeToLower(char c)
        {
            
            if ((c >= 'A' && c <= 'Z'))
            {
                c = (char)(c - 'A' + 'a');
                Console.WriteLine("Here is Lower charater you want: {0} ", c);
            }
            else if ((c >= 'a' && c <= 'z'))
                Console.WriteLine("Here is Lower charater you want: {0} ", c);
            else
                Console.WriteLine("the character you give is Not in letter characters ");
            
        }
    }
}
