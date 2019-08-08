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
            var arraySize = Convert.ToInt32(Console.ReadLine());
            var c = new Calculation(arraySize);
            int[] array = c.Fill();
            Console.WriteLine("Исходный массив: ");
            foreach (var a in array)
            {
                Console.Write(a + "  ");
            }
            Console.WriteLine("\n" + new string('_', 50));

            Console.WriteLine("Введите период скользящего среднего: ");
            var period = Convert.ToInt32(Console.ReadLine());
            if (period < 1 || period > arraySize)
            {
                throw new ArgumentException("Период скользящего среднего должен быть больше 1 и меньше размера массива!");
            }
            Console.WriteLine("Скользящее среднее: ");
            int[] arrayMovingAverage = c.GetMovingAverage(period);
            foreach (var a in arrayMovingAverage)
            {
                Console.Write(a + "  ");
            }
            Console.WriteLine("\n" + new string('_', 50));

            Console.WriteLine("Отношение каждого следующего элемента к предыдущему: ");
            int[] arrayRatio = c.GetRatio();
            foreach (var a in arrayRatio)
            {
                Console.Write(a + "  ");
            }

            Console.ReadKey();
        }
    }
}
