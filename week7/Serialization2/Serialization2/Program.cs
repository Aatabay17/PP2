using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization2
{
    [Serializable]
    public class Employee
    {
        public string name, ID;
        public int Salary;
        public Employee() { }
        public Employee(string name, string ID, int Salary)
        {
            this.name = name;
            this.ID = ID;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return name + " " + ID + " " + Salary;
        }
        public void Serialize()
        {
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Employee));
            try
            {
                xm.Serialize(fs, this);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fs.Close();
            }
            Console.WriteLine("Done");
            Console.ReadKey();

        }
        public void Deserialize()
        {
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Employee));
            try
            {
                Employee s = xm.Deserialize(fs) as Employee;
                Console.WriteLine(s);
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fs.Close();
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee("Assem", "18BD110323", 100000);
            s1.Serialize();
            Console.ReadKey();
            s1.Deserialize();
            Console.ReadKey();


        }
    }
}