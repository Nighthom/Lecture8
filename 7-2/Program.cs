using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

class Boarding
{
    public string Name { get; set; }


    public void Print()
    {
        Console.WriteLine("-------------------------");
        Console.Write("이름 : " + Name + " ");
        string position = null;
        if (this is Pilot)
            position = "파일럿";
        else if (this is Stewardess)
            position = "승무원";
        else if (this is Passanger)
            position = "탑승객";
        Console.WriteLine("구분 : " + position);
    }
}

class Pilot : Boarding
{
    public Pilot(string name)
    {
        Name = name;
    }
}
class Stewardess : Boarding
{
    public Stewardess(string name)
    {
        Name = name;
    }
}
class Passanger : Boarding
{
    public Passanger(string name)
    {
        Name = name;
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
            }
        }
    }
}
