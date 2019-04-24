using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mid2
{
    public class TrafficJam
    {
        public string color;
       public TrafficJam(string color)
        {
            this.color = color;
        }
        public TrafficJam() { }
        public void Traffic()
        {
            string s = "O";
            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        color = "RED";
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(s);
                        color = "GRAY";
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(s);
                        color = "GRAY";
                        Thread.Sleep(1000);
                    }
                    if (i == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        color = "GRAY";
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(s);
                        color = "Yellow";
                        Console.ForegroundColor = ConsoleColor.Gray;
                        color = "GRAY";
                        Console.WriteLine(s);
                        Thread.Sleep(1000);

                    }
                    if (i == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        color = "GRAY";
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        color = "GRAY";
                        Console.WriteLine(s);
                        Console.ForegroundColor = ConsoleColor.Green;
                        color = "GREEN";
                        Console.WriteLine(s);
                        Thread.Sleep(1000);
                    }
                }
                Console.Clear();
            }
        }
    }
    public class Program
    {
        static void Main(string[] args) {
            Console.CursorVisible = false;
            TrafficJam tj = new TrafficJam();
            Thread t = new Thread(tj.Traffic);

            t.Start();

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
           
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                t.Abort();
                t.Join(5000);
                Console.WriteLine("sasdasd");
                FileStream fs = new FileStream("traffic.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer xm = new XmlSerializer(typeof(TrafficJam));
                xm.Serialize(fs, t);
                fs.Close();
            }
                Console.ReadKey();
            
        }
    }
}
            
