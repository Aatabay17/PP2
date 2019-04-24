using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.Spacebar:

                    while (true)
                    {
                        for (int i = 6; i < 13; i++)
                        {
                            Console.WriteLine("######");
                            Console.WriteLine("#.#");
                            Console.WriteLine("##");
                            Console.SetCursorPosition(i, 0);
                            Console.Write('$');
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                    }




            }



        }
    }
}