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
                Show sh = new Show(n);
                sh.ShowCalculation();
            }
            else if (n > 100)
                Console.WriteLine("Слишком большое значение!");
            else
                Console.WriteLine("Размер массива должен быть больше нуля!");

            Console.ReadKey();
        }
    }
}
