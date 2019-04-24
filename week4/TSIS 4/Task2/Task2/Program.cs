using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Task2
{
    public class Mark
    {
        public int score;
        public Mark(int score)
        {
            this.score = score;
        }
        public string getLetter()
        {
            if (score >= 95)
            {
                return ("A");
            }
            else if (score >= 90)
            {
                return ("A-");
            }

            else if (score >= 85)
            {
                return ("B+");
            }
            else if (score >= 80)
            {
                return ("B");
            }
            else if (score >= 75)
            {
                return ("B-");
            }
            else if (score >= 70)
            {
                return ("C+");
            }
            else if (score >= 65)
            {
                return ("C");
            }
            else if (score >= 60)
            {
                return ("C-");
            }
            else if (score >= 55)
            {
                return ("D+");
            }
            else if (score >= 50)
            {
                return ("D");
            }
            else if (score >= 0 && score < 50)
            {
                return ("F");
            }
            return "ok";
        }

        public override string ToString()
        {
            return this.score + " " + this.getLetter();
        }

        public Mark() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Xml();
            Dxml();
        }
        public static void Xml()
        {
            List<Mark> bookList = new List<Mark>();
            bookList.Add(new Mark(0));
            bookList.Add(new Mark(100));

            FileStream fs = new FileStream("task2.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xm = new XmlSerializer(typeof(List<Mark>));
            xm.Serialize(fs, bookList);
            fs.Close();
        }
        public static void Dxml()
        {
            FileStream fs = new FileStream("task2.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xm = new XmlSerializer(typeof(List<Mark>));
            List<Mark> bookList = xm.Deserialize(fs) as List<Mark>;
            foreach (Mark p in bookList)
            {
                p.getLetter();
                Console.WriteLine(p.ToString());
            }
            fs.Close();
            Console.ReadKey();
        }
    }
}

