using System;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string elements = Console.ReadLine();
            string[] array = elements.Split();

            int n = int.Parse(num);

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}