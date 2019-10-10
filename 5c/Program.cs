using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5c
{
    class Program
    {
        static void Main(string[] args)
        {
            String f = @"C:\187pm14039\Ex5\Text.txt";

            string testData = File.ReadAllText(f);
           
                Console.WriteLine(testData);
            
        }
    }
}
