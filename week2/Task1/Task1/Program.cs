using System;
using System.IO;

namespace Task1
{
    class Program
    {

       public static bool palindrome(string s)
        {
            int length = s.Length;
            for(int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            string path = ("input.txt");
            StreamReader sw = new StreamReader(path);
            string s = sw.ReadLine();
            sw.Close();

            if (palindrome(s) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");

            }
            Console.ReadKey();
        }
    }
}


