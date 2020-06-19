using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string Numbers = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите числа которые хотите выбрать");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (a == i)
                {
                    Console.WriteLine($"Выбранные числа {i}");
                }
            }
            Console.ReadLine();
        }
    }
}