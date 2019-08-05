using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Show
    {
        int N { get; set; }
        public Show(int n)
        {
            this.N = n;
        }
        public void ShowCalculation()
        {
            Calculation c = new Calculation(N);
            Console.WriteLine("Исходный массив: ");
            c.Fill();
            Console.WriteLine("\n" + new string('_', 50));

            Console.WriteLine("Введите период скользящего среднего: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p > 1 && p < N)
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
    }
}
