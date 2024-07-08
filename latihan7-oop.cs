using System;

public class Car
{
    public string Model {get; set;}
    public string Color {get; set;}
    public int Year {get; set;}

    // bikin constructor
    public Car(string model, string color, int year)
    {
        Model = model;
        Color = color;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Color: {Color}, Year: {Year}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Beat karbu","Red", 2008);
        myCar.DisplayInfo();
    }
}