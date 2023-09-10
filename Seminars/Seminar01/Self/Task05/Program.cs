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
            Console.WriteLine("Введите напряжение системы и сопротивление:\n");
            double U = double.Parse(Console.ReadLine()),
                   R = double.Parse(Console.ReadLine());

            Console.WriteLine("Сила тока равна {0} А\nМощность тока равна {1} Вт", U / R, U * U / R);
            Console.ReadKey();

        }
    }
}
