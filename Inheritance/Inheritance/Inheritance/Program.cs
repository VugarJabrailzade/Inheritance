using System;

    namespace Inheritance
{
    public class Person
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname; 
            Age = age;

        }
        public void GetInormation()
        {
            Console.WriteLine("Keep going to study");
        }

    }

    public class Teacher : Person
    {
        public Teacher(string name, string surname, int age) : base(name, surname,age) { }
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }

    }
    public class Student : Person
    {
       
        public Student(string name, string surname, int age) : base(name, surname, age) {}
        public void Learn()
        {
           Console.WriteLine("Learning...");
          
        }
    }


    class Program
    {

        public static void Main(string[] args)
        {
            Teacher teacher = new("Sara", "Aliyeva",42);
            Student student = new("Yaver","Rovshenli",16);

            Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age);
            student.Learn();
           
            Console.WriteLine(teacher.Name + " " + teacher.Surname + " " + teacher.Age);
            teacher.Explain();
            
            student.GetInormation();








        }


    }
    



















}


