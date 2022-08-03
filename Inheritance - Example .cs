using System;
namespace ConsoleApp
{
    class human
    {
        public string name;
        public string gender;
        public human(string n, string g) //constructor
        {
            name = n;
            gender = g;
            Console.WriteLine("01.Name: " + name + "\t\t--->Base Class");
            Console.WriteLine("02.Gender: " + gender + "\t\t\t\t--->Base Class");
        }
    }
    class Student : human
    {
        public string pre_education;
        public Student(string n, string g, string p_e) : base(n, g) //constructor
        {
            pre_education = p_e;
            Console.WriteLine("03.Previous Education: " + pre_education + "\t--->Derived Class");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>STUDENT DETAILS:");
            Student s01 = new Student("Shareyar farooqui", "Male", "intermediate");
        }
    }
}
