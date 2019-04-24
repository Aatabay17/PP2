using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());//give a size
            for (int i = 0; i < n; i++)//create first loop
            {
                for (int j = 0; j < i + 1; j++)//create second one
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
