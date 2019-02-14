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
                string FilePath1 = @"C:\Users\user\Desktop\Week2\path\file.txt";//show a path 
                string FilePath2 = @"C:\Users\user\Desktop\Week2\path1\file.txt";//show another path
            StreamWriter sw = new StreamWriter(FilePath1);//creates a file
                sw.WriteLine("random string");
                sw.Close();
                File.Copy(FilePath1, FilePath2);//copies from first one to second 
            File.Delete(FilePath1);//deletes first one

            }
        }
    }