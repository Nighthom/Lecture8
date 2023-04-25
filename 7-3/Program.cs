using System;
using System.Collections.Generic;

class AutoShoppingMall
{
    public AutoShoppingMall(string name) { }
    public AutoShoppingMall() { }

    public virtual string GetVehicleName() { return null; }
    public void Print()
    {
        string vehicle = GetVehicleName();

        Console.WriteLine("판매 차종 : " + vehicle);
    }

    public void Sell()
    {
        Console.WriteLine("판매 완료!");
    }
}

class Bycycle : AutoShoppingMall
{
    public Bycycle(string name) : base(name) { }
    public Bycycle() : base() { }
    public override string GetVehicleName()
    {
        return "자전거";
    }

    public new void Sell()
    {
        Console.WriteLine($"{GetVehicleName()} 판매 완료!");
    }
}

class Bike : AutoShoppingMall
{
    public Bike(string name) : base(name) { }
    public Bike() : base() { }
    public override string GetVehicleName()
    {
        return "오토바이";
    }

    public new void Sell()
    {
        Console.WriteLine($"{GetVehicleName()} 판매 완료!");
    }
}

class Car : AutoShoppingMall
{
    public Car(string name) : base(name) { }
    public Car() : base() { }
    public override string GetVehicleName()
    {
        return "자동차";
    }

    public new void Sell()
    {
        Console.WriteLine($"{GetVehicleName()} 판매 완료!");
    }
}

namespace _7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AutoShoppingMall> list = new List<AutoShoppingMall>()
                { new Bycycle(), new Bike(), new Car() };

            foreach(var autoShop in list)
            {
                autoShop.Print();
                // 자녀 메서드는 하이딩되어 호출 X
                autoShop.Sell();
            }
        }
    }
}
