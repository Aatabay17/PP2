using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        class Pen
        {
            public char sign = '#';
            public int x, y;
            public Pen()
            {
                x = 0;
                y = 10;
            }


        
            public void Draw()
            {
                bool isRed = false;

                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    if (isRed)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(sign);

                    if (x == 30) { x = 0; isRed=!isRed; }
                    else x++;
                    for (int i = 0; i <= 30;i++)
                    {
                        Thread.Sleep(10);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            Thread thread = new Thread(new ThreadStart(pen.Draw));
            thread.Start();
        }


}
}
