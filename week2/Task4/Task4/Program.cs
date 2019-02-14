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
         static void Main(string[] args)
            {
                string FilePath1 = @"C:\Users\user\Desktop\Week2\path\file.txt";
                string FilePath2 = @"C:\Users\user\Desktop\Week2\path1\file.txt";
                StreamWriter sw = new StreamWriter(FilePath1);
                sw.WriteLine("random string");
                sw.Close();
                File.Copy(FilePath1, FilePath2);
                File.Delete(FilePath1);

            }
        }
    }