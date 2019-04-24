using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
       public static bool IsPrime(int x)//create function,which checks for the primes
        {
            if (x == 1) return false;

            for (int i = 2; i < x; ++i)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\PP2\week2\input2.txt");//reads our file from a given location 
            string line = sr.ReadLine();//saves it to a string
            sr.Close();
            string[] nums = line.Split();//Split it in array
            StreamWriter sw = new StreamWriter(@"C:\Users\user\Desktop\PP2\week2\output2.txt");//write in another file using our function

            foreach (string x in nums)
            {
                if (IsPrime(int.Parse(x)) == true)
                {
                    sw.Write(x + " ");
                }
            }
            sw.Close();
        }
    }
}
