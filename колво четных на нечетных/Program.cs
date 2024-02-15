using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace колво_четных_на_нечетных
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n];
            int s = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i+=2)
            {
                if ((array[i] % 2 == 1)&&(array[i] >0))
                   s++;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }

    }
}
