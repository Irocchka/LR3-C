using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Car : IEquatable<Car>
{
    public string Name;
    public string Engine;
    public int MaxSpeed;

    public Car(string Name,string Engine,int MaxSpeed)
    {
        this.Name = Name;
        this.Engine = Engine;
        this.MaxSpeed = MaxSpeed;
        Console.WriteLine($"{Name} {Engine} {MaxSpeed}");
    }

    public bool Equals(Car other)
    {
        return this == other;
    }

    public override string ToString()
    {
        return Name;
    }
}

class CarsCatalog
{
    public List<Car> cars = new List<Car>();//List только для строк
    public CarsCatalog(params Car[] car)
    {
        for(int i = 0; i < car.Length; i++)
        {
            this.cars.Add(car[i]);
        }
    }
    public string this[int index]
    {
        get => $"{cars[index].Name} ; { cars[index].Engine}";
    }

}

 class Program
    {
        static void Main(string[] args)
        {
        CarsCatalog c1 = new CarsCatalog(new Car("Audi a4", "V6", 180), new Car("BMW x6", "V3", 230),new Car("Mers","V1",200));
        string mrr=c1[0].ToString();
        
        for (int i = 0; i < 3; i ++)
        {
            Console.WriteLine(c1[i].ToString());
        }
        }
  }

