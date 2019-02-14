using System;

namespace Task1
{
    class Program
    {
        public static bool Prime(int a)//create function,which finds prime numbers
        {
            bool ch = true;
            if (a == 1) ch = false;
            for (int i = 2; i < a; i++)//if it is prime,it will not divide on previous numbers until our number
            {
                if (a % i == 0)
                {
                    ch = false;
                }
            }
            return ch;
        }
        static void Main(string[] args)
        {

            int n;
            n = int.Parse(Console.ReadLine());//size of array
            string s = Console.ReadLine();   
            string[] arr = s.Split();//split our elements
            int cnt = 0;//counter
            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]);//make our element in array a number
                if (Prime(c) == true)//checking
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);//print counter

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]);
                if (Prime(c) == true)
                {
                    Console.Write(c + " ");//print our prime numbers
                }
            }
            Console.ReadKey();
        }
    }
}
