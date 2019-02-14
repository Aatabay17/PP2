using System;

namespace Task2
{
    class Student
    {
        public string Name, ID;
        public int year;

        public Student(string Name, string ID)//Creating a constrictor,which includes 2 parameteres
        {
            this.Name = Name;
            this.ID = ID;
            this.year = 1;
        }

        public string getName()
        {
            return this.Name;
        }
        public string getID()
        {
            return this.ID;
        }
    
        public void Increment()
        {
            this.year++;
        }

        public override string ToString()
        {
            return this.Name + " " + this.ID + " " + this.year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Alim", "18BD110323");//we use our constructor and give values to each parameter
            s.Increment();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
