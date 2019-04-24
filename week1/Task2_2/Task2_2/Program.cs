using System;

namespace Task2_2
{

    public class Student
    {
        public string name;
        public string ID;
        public int year;

        public Student(string name,string ID)
        {
            this.name = name;
            this.ID = ID;
            this.year = 1;
        }

        public string Getname()
        {
            return this.name;
        }
        public string GetID()
        {
            return this.ID;
        }

        public void Increment()
        {
            this.year++;
        }

        public override string ToString() 
        {
            return this.name + " " + this.ID + " " + this.year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alim" , "18BD110323");
            //student.name = "Alim";
            //student.ID = "18BD110323";
            student.Increment();
            Console.WriteLine(student);
        }
    }
}
