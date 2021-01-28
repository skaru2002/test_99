using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, j = 1, n =0;

            //for (i = 2; i <= 9; i++)
            //{
            //    Console.WriteLine("{0}단\n", i);
            //    for (j = 1; j <= 9; j++)
            //    {
            //        n = i * j;
            //        Console.WriteLine("{0}*{1}={2}", i, j, n);
            //    }
            //}
            //Console.WriteLine("Hello World!");

            //while (i<10)
            //{
            //    Console.WriteLine("\n{0}단", i);
            //    while (j<10)
            //    {
            //        Console.WriteLine("{0}*{1}={2}", i, j, i * j);
            //        j++;
            //    }
            //    i++;
            //    j = 1;
            //}

            //while (i<10)
            //{
            //    if (j==1)
            //    {
            //        Console.WriteLine("\n{0}단", i);
            //    }

            //    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
            //    j++;

            //    if (j == 10)
            //    {
            //        i++;
            //        j = 1;
            //    }
            //}

            //for (i = 2; i <= 9; i++)
            //{
            //    Console.WriteLine("{0}단\n", i);
            //    for (j = 1; j <= 9; j++)
            //    {
            //        n = i * j;
            //        Console.WriteLine("{0}*{1}={2}", i, j, n);
            //    }
            //}
            //Console.WriteLine("Hello World!");

            
            while (i+j > 18)
            {
                Console.WriteLine("{0}단\n", i);
                Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                j++;

                break;


            }

        }

        
    }
}
