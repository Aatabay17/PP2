using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {

        public static void f(int x)
        {
            bool ok = false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    ok= true;
                }
                if (!ok) Console.WriteLine(x);
            }
        }


        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string a1 = Console.ReadLine();
            List<string> pr = new List<string>();
            int n = int.Parse(a);

            string[] arr = a1.Split();
            for(int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(arr[i]);
                if (ok=true)
                {
                    List<string>.pr.Add(a[i]);
                }
                List<string>.pr.Count(a[i]);
            }
            
            Console.ReadKey();
        }
        
        }
    }
