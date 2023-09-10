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
            string Surname = Console.ReadLine(),
                   Name    = Console.ReadLine(),
                   FName   = Console.ReadLine();

            Console.WriteLine("\n{0} {1} {2}", Surname, Name, FName);
            Console.ReadKey();
        }
    }
}
