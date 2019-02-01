using System;

public class Consoleapp
{
    static void Main(string []args)
    {
        string n = Console.ReadLine();
        int a = int.Parse(n);
        for(int i = 0; i<a; i++)
        {
            for(int j=0; j < i; j++)
            {
                Console.WriteLine('*');
                Console.ReadKey();
            }
        }








    }
}
