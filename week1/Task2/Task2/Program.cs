using System;

namespace Task2
{
    class Student//create class
    {
      
            public string name;//name of student
            public string id;//ID if student
            public int year = 1;//year of student

            public Student(string name, string id)//create a constructor
            {
                this.name = name;//name will be our name in constructor 
                this.id = id;//the same as with name
            }
            public void print()//function which prints
            {
                year += 1;//increases year
                Console.WriteLine(name + " " + id + " " + year);//prints our name,id and year
            }
        }
        class Program
        {
        static void Main(string[] args)
        {
            Student st1 = new Student("Alim", "18BD110323");//create new class student and give parameters 
            st1.print();//call our function
        }
        }
    }