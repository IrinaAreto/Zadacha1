using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n <= 100)
            {
                Calculation c = new Calculation(n);
                Console.WriteLine("Исходный массив: ");
                c.Fill();
                Console.WriteLine("\n" + new string('_', 50));

                Console.WriteLine("Введите период скользящего среднего: ");
                int p = Convert.ToInt32(Console.ReadLine());
                if (p > 1 && p < n)
                {
                    Console.WriteLine("Скользящее среднее: ");
                    c.CalculateSMA(p);
                    Console.WriteLine("\n" + new string('_', 50));
                }
                else
                    Console.WriteLine("Период скользящего среднего должен быть больше 1 и меньше размера массива!");

                Console.WriteLine("Отношение каждого следующего элемента к предыдущему: ");
                c.CalculateRatio();
            }
            else if (n > 100)
                Console.WriteLine("Слишком большое значение!");
            else
                Console.WriteLine("Размер массива должен быть больше нуля!");

            Console.ReadKey();
        }
    }
}
