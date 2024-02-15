using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_по_возр_5_по_убыв
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                // array[i] = random.Next(0, 50);
                array[i] = i;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write("{0} ", array[i]);
            }
            for (int i = 5; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
