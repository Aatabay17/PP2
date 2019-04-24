using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        public int age;
        public Student() { }
        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + age;
        }
        public void Serialize()
        {
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Student));
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
            XmlSerializer xm = new XmlSerializer(typeof(Student));
            try
            {
                Student s = xm.Deserialize(fs) as Student;
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
            Student s1 = new Student("Assem", "Dosniyaz", 18);
            s1.Serialize();
            Console.ReadKey();
            s1.Deserialize();
            Console.ReadKey();


        }
    }
}