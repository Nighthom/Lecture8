using System;
using System.Collections.Generic;

class AutoShoppingMall
{
    public void Print()
    {
        string vehicle = "";
        if (this is Bycycle)
            vehicle = "자전거";
        else if (this is Bike)
            vehicle = "오토바이";
        else if (this is Car)
            vehicle = "자동차";

        Console.WriteLine("차종 : " + vehicle);
    }
}

class Bycycle : AutoShoppingMall
{

}

class Bike : AutoShoppingMall
{

}

class Car : AutoShoppingMall
{

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
            }
        }
    }
}
