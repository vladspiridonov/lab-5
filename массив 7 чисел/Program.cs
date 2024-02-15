using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив_7_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] array = new int [n];
            int s = 0;
            //double a = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", array [i]);
            }
            for (int i = 0; i < n; i++)
            {
                s += array[i];
               
            }
            //a = ((double)s) / n;
            Console.WriteLine(((double)s) / n);
            Console.ReadKey();
        }
    }
}
