using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Printspaces(int lvl)
        {
            for(int i = 0; i < lvl; i++)
          
                Console.Write(" ");
        }

        static void task(DirectoryInfo directory,int lvl)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach(FileInfo file in files)
            {
                Printspaces(lvl);
                Console.WriteLine(file.Name);
            }

            foreach(DirectoryInfo d in directories)
            {
                Printspaces(lvl);
                Console.WriteLine(d.Name);
                task(d, lvl + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/user/Desktop/PP2/week2");
            task(d, 1);
            Console.ReadKey();
        }
    }
}