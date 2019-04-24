using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        public static void output()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(output);
                threads[i].Name = "Thread's name is  " + (i + 1);
            }


            for (int i = 0; i < 3; i++)
            {
                threads[i].Start();
             //   Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
