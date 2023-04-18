using System;
using System.Collections.Generic;

class UniversityMember
{
    public string Name { get; set; }

    public UniversityMember(string name)
    {
        Name = name;
    }
    public UniversityMember()
    {
        Name = "";
    }
    public void Breath()
    {
        Console.WriteLine("숨 쉬기");
    }

    public void Print()
    {
        Console.WriteLine("----------------------------");
        Console.Write("이름 : " + Name + " ");

        string position = null;
        if(this is Student)
            position = "학생";
        else if(this is Professor)
            position = "교수";
        else if(this is Employee)
            position = "직원";

        Console.WriteLine("직책 : " + position);
    }
}

class Student : UniversityMember
{
    public Student(string name)
    {
        Name = name;
    }

    public Student() { }
}

class Professor : UniversityMember
{
    public Professor(string name)
    {
        Name = name;
    }
    public Professor() { }
}

class Employee : UniversityMember
{
    public Employee(string name)
    {
        Name = name;
    }
    public Employee() { }
}

namespace _7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UniversityMember> list = new List<UniversityMember>()
            { new Student("윤승준"), new Employee("이만희"), new Student("승준"), 
            new Professor("승준"), new Student("이"), new Employee("윤") };

            foreach(var human in list)
            {
                human.Print();
            }
        }
    }
}
