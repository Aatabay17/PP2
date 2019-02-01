using System;

namespace ConsoleApp6
{

    class Student
    {
        public string name;
        public string gpa;
        public Student(string n, string g)
        {
            name = n;
            gpa = g;
        }
        public void PrintInfo()
        {
            Console.WriteLine(name + " " + gpa);
        }
    }

    class Master : Student
    {
        public string thesis;
        public Master(string n, string g, string t) : base(n, g)
        {
            thesis = t;
        }

        public void PrintInfo2()
        {
            base.PrintInfo();
        }
    }

    class Program { 
 
            Student s = new Student("Omarov", "3.5");
        Student s2 = new Student("Talipov", "4.0");
        
            s.PrintInfo();
            s2.PrintInfo();
            Master m = new Master("Сabitov", "3.6", "C#");
            m.PrintInfo2();
        }
}
