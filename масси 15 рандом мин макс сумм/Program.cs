using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace масси_15_рандом_мин_макс_сумм
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            //int s = 0;
            int min = 50;
            int max = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("{0}, {1}", min, max);
            Console.WriteLine(min+max);
            Console.ReadKey();
        }
    }
}
