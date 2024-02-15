using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   // Console.Write(" ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }                
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            int m = (n * 2) + 2;
            int[] summ= new int [m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ[i] += array[i, j];
                }                
            }            
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    summ[n+j] += array[i, j];
                }
                           }            
            for (int i = 0; i < n; i++)
            {
                summ[2*n] += array[i, i];
                
            }
            for (int i = n-1; i >= 0; i--)
            {
                summ[2 * n + 1] += array[i, i];

            }
            for (int i = 0; i < m; i++)
            {                
                Console.WriteLine(summ[i]);
            }
            for (int i = 0; i < m-2; i++)
            {
                if (summ[i]!=summ[i+1])
                {
                    Console.WriteLine("not magic");
                    break;
                }
                else
                {
                    if(i==m-3)
                        Console.WriteLine("MAGIC!");
                }
            }
            Console.ReadKey();
            
        }
    }
}
