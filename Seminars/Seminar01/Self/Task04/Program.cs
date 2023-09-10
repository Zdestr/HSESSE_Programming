using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Solution
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = (ConsoleColor) 3;
            Console.ForegroundColor = (ConsoleColor) 2;
            string Name = Console.ReadLine();

            Console.WriteLine("\nЗдравствуйте, {0}!", Name);
            Console.ReadKey();
        }
    }
}
