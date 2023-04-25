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
    public virtual string GetPosName() { return null; }
    public void Print()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"이름 : {Name}, 직책 : {GetPosName()}");
    }
}

class Student : UniversityMember
{
    public Student(string name) : base(name)
    {
    }

    public Student() { }

    public new void Breath()
    {
        Console.WriteLine("학생 숨 쉬기");
    }

    public override string GetPosName()
    {
        return "학생";
    }
}

class Professor : UniversityMember
{
    public Professor(string name) : base(name)
    {
    }
    public Professor() { }

    public new void Breath()
    {
        Console.WriteLine("교수 숨 쉬기");
    }

    public override string GetPosName()
    {
        return "교수";
    }
}

class Employee : UniversityMember
{
    public Employee(string name) : base(name)
    {
    }
    public Employee() { }

    public new void Breath()
    {
        Console.WriteLine("직원 숨 쉬기");
    }

    public override string GetPosName()
    {
        return "직원";
    }
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

            foreach(var member in list)
            {
                member.Print();

                // 자녀의 멤버 함수는 하이딩되어 사용되지 않는다.
                member.Breath();
                // 자녀의 메서드를 사용하고 싶으면 적절한 자료형으로 캐스팅하여 호출한다.
            }
        }
    }
}
