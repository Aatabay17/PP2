using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    class Program
    {
        public static void CreateFile()
        {
            FileInfo file = new FileInfo(@"C:\Users\user\Desktop\Week2\path\file.txt");
            FileStream f = file.Create();
        }
        public static void CopyFile()
        {
            string path1 = @"C:\Users\user\Desktop\Week2\path\file.txt";
            string path2 = @"C:\Users\user\Desktop\Week2\path1\file.txt";
            FileInfo f1 = new FileInfo(path1);
            FileInfo f2 = new FileInfo(path2);
            f1.CopyTo(path2);
        }
        public static void DeleteFile()
        {
            FileInfo f = new FileInfo(@"C:\Users\user\Desktop\Week2\path\file.txt");
            f.Delete();
        }
        static void Main(string[] args)
        {
            CreateFile();
        }
    }
}

