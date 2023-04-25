using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Boarding
{
    public string Name { get; set; }

    public Boarding(string name)
    {
        Name = name;
    }
    public Boarding()
    {
        Name = null;
    }

    public virtual string GetPosName() { return null; }
    public void Print()
    {
        Console.WriteLine("-------------------------");
        Console.Write("이름 : " + Name + " ");
        string position = GetPosName();
        Console.WriteLine("구분 : " + position);
    }

    public void Breath()
    {
        Console.WriteLine("숨 쉬기");
    }
}

class Pilot : Boarding
{
    public Pilot(string name) : base(name)
    {
    }
    public Pilot() : base() { }

    public override string GetPosName()
    {
        return "파일럿";
    }

    public new void Breath()
    {
        Console.WriteLine("파일럿 숨 쉬기");
    }
}
class Stewardess : Boarding
{
    public Stewardess(string name) : base(name)
    {
    }
    public Stewardess() : base() { }
    public override string GetPosName()
    {
        return "승무원";
    }

    public new void Breath()
    {
        Console.WriteLine("승무원 숨 쉬기");
    }
}
class Passanger : Boarding
{
    public Passanger(string name) : base(name)
    {
    }
    public Passanger() : base() { }
    
    public override string GetPosName()
    {
        return "탑승객";
    }

    public new void Breath()
    {
        Console.WriteLine("탑승객 숨 쉬기");
    }
}


namespace _7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Boarding> list = new List<Boarding>()
                { new Stewardess("승아"), new Passanger("승준"), new Pilot("승민"), 
                new Passanger("이")};

            foreach(var boarding in list)
            {
                boarding.Print();

                // 자녀 메서드가 부모 메서드에 하이딩됨
                boarding.Breath();
            }
        }
    }
}
