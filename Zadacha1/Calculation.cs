using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Calculation
    {
        int[] array;
        int[] arraySMA;
        int[] newArray;
        int n;
        Random rand = new Random();
        public Calculation(int n)
        {
            this.n = n;
            array = new int[n];
        }
        public void Fill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 25);
                Console.Write(array[i] + "  ");
            }
        }
        public void CalculateSMA(int p)
        {
            arraySMA = new int[n - p + 1];
            for (int j = 0; j <= (n - (p - 1)) && j < arraySMA.Length; j++)
            {
                int sum = 0;
                for (int i = j + p - 1; i >= j && i < array.Length; i--)
                {
                    sum += array[i];
                }
                arraySMA[j] = sum / p;
            }
            foreach (int a in arraySMA)
                Console.Write(a + "  ");
        }
        public void CalculateRatio()
        {
            newArray = new int[n - 1];
            for (int i = 0; i < newArray.Length; i++)
                if (array[i] != 0)
                    newArray[i] = array[i + 1] / array[i];
                else
                    newArray[i] = 0;  
            foreach (int a in newArray)
                Console.Write(a + "  ");
        }
    }
}

