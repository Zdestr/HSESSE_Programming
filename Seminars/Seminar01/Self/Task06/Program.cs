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
            Console.WriteLine("Введите длины 2 катетов:\n");
            double A = double.Parse(Console.ReadLine()),
                   B = double.Parse(Console.ReadLine());

            Console.WriteLine("Гипотенуза равна {0}", Math.Sqrt(A*A + B*B));
            Console.ReadKey();

        }
    }
}
