using System;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            string num = Console.ReadLine();//size of array
            string elements = Console.ReadLine();
            string[] array = elements.Split();//split our elements

            int n = int.Parse(num);

            for (int i = 0; i < n; i++)//go through array and print each element twice
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}


