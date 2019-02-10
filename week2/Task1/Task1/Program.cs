using System;

namespace Task1
{
    class Program
    {

       public static bool palindrome(string s)
        {
            char[] letter = new char[s.Length];
            letter = s.ToCharArray();
            int length = s.Length;
            for(int i = 0; i < length / 2; i++)
            {
                if (letter[i] != letter[length - i - 1])
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            string direction = (@"C:\Users\user\Desktop\PP2\week2\input1.txt");
            string check = System.IO.File.ReadAllText(direction);
            if (palindrome(check) == true)
            {
                Console.WriteLine("YES");
            }
            Console.ReadKey();
        }
    }
}
