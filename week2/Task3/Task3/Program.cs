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
        static void Printspaces(int lvl)//shows how much space we need to show all directories and files hierarchically
        {
            for(int i = 0; i < lvl; i++)
          
                Console.Write(" ");
        }

        static void task(DirectoryInfo directory,int lvl)
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach(FileInfo file in files)//if it is file,show the file's name
            {
                Printspaces(lvl);
                Console.WriteLine(file.Name);
            }

            foreach(DirectoryInfo d in directories)//show the folder's name
            {// then recall the fucntion (recursion) to show the consistent of the folder
                Printspaces(lvl);
                Console.WriteLine(d.Name);
                task(d, lvl + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("/Users/user/Desktop/PP2/week2");
            task(d, 0);
            Console.ReadKey();
        }
    }
}