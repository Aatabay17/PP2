using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string a2 = Console.ReadLine();

            int n = int.Parse(a);
            //string[] numsStr = a2.Split(new char[] { ',', ' ', ';', '#', '$' });
            string[] numsStr = a2.Split();

            for (int i = 0; i < numsStr.Length; ++i)
            {
                int x = int.Parse(numsStr[i]);
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");
                }
       
            }
            Console.ReadKey();
        }
    }
}