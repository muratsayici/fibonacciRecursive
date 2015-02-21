using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Program
    {
        public static Stopwatch watch = new Stopwatch();

        static void Main(string[] args)
        {
            long deger = 0;
            Console.Write("Kacinci Fibonacciyi Bulayim : ");
            deger = Convert.ToInt64(Console.ReadLine());
    
            watch.Start();
            Console.WriteLine("{0} . Fibonacci: {1}", deger, recursive(deger));
            watch.Stop();

            Console.WriteLine("Gecen sure: {0} ", watch.Elapsed.ToString());
            Console.ReadLine();

        }
        public static long recursive(long girdi)
        {

            if (girdi == 1 || girdi == 2)
            {
                return 1;
            }
            else

                return (recursive(girdi - 1) + recursive(girdi - 2));
        }
    }
}
