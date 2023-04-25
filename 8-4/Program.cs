using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _8_4
{
    abstract class HomeAppliance
    {
        public abstract string GetName();
    }

    class TV : HomeAppliance
    {
        public override string GetName()
        {
            return "TV";
        }
    }

    class Radio : HomeAppliance
    {
        public override string GetName()
        {
            return "Radio";
        }
    }

    class Refrigirator : HomeAppliance
    {
        public override string GetName()
        {
            return "Refrigirator";
        }
    }

    abstract class BroadcastProg
    {
        public string Name { private get; set; }

        public BroadcastProg(string name)
        {
            Name = name;
        }

        public abstract string GetBroadcastCategory();

        public void PrintBroadcastData()
        {
            string category = GetBroadcastCategory();

            Console.WriteLine($"방송 제목 : {Name}, 방송 카테고리 : {category}");
        }
    }

    class Movie : BroadcastProg
    {
        public Movie(string name) : base(name) { }

        public override string GetBroadcastCategory()
        {
            return "영화";
        }
    }

    class News : BroadcastProg
    {
        public News(string name) : base(name) { }

        public override string GetBroadcastCategory()
        {
            return "뉴스";
        }
    }
    class Drama : BroadcastProg
    {
        public Drama(string name) : base(name) { }

        public override string GetBroadcastCategory()
        {
            return "드라마";
        }
    }

    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Triangle : Shape
    {
        public double Height;
        public double Base;
        public Triangle(double height, double _base)
        {
            Height = height;
            Base = _base;
        }
        public override double GetArea()
        {
            return (Height * Base) / 2;
        }
    }

    class Rectangle : Shape
    {
        public double Horizontal;
        public double Vertical;

        public Rectangle(double horizontal, double vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        public override double GetArea()
        {
            return Horizontal * Vertical;
        }
    }

    class Circle : Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- 가전 제품 TestCase ----------------");
            List<HomeAppliance> list = new List<HomeAppliance>()
            { new TV(), new Refrigirator(), new Radio()};
            
            foreach (var item in list)
                Console.WriteLine($"가전 제품 이름 : {item.GetName()}");

            Console.WriteLine("--------------- 방송 프로 TestCase ----------------");
            List<BroadcastProg> list2 = new List<BroadcastProg>()
            {
                new Movie("아바타"), new News("9시 뉴스"), new Drama("돈의 화신")
            };

            foreach (var item in list2)
                item.PrintBroadcastData();

            Console.WriteLine("--------------- 도형 TestCase ----------------");

            List<Shape> list3 = new List<Shape>
            {
                new Triangle(3, 3), new Rectangle(3, 3), new Circle(3)
            };
            
            foreach(var item in list3)
                Console.WriteLine($"도형의 넓이 : {item.GetArea()}");
        }
    }
}
