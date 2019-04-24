using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class Complex
    {
        public int real;
        public int imaginary;

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public Complex() { }

        public override string ToString()
        {
            return this.real + " " + "+ " + this.imaginary + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Complex complex = new Complex(4, 5);
            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, complex);
            fs.Close();

            FileStream fs1 = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs1 = new XmlSerializer(typeof(Complex));
            Complex complex1 = xs.Deserialize(fs1) as Complex;
            Console.WriteLine(complex1.ToString());
            fs1.Close();
            Console.ReadKey();
        }
    }
}
    
