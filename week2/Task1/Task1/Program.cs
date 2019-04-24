using System;
using System.IO;

namespace Task1
{
    class Program
    {

       public static bool palindrome(string s)//create function,which checks for palindrome of the string
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
            StreamReader sw = new StreamReader("input.txt");//reads the file from given direction 
            string s = sw.ReadLine();//saves to string "s"
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


