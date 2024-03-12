class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} ({Year})";
    }
}

struct Temperature
{
    public double Celsius { get; set; }
    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    public double Fahrenheit => Celsius * 9 / 5 + 32;

    public override string ToString()
    {
        return $"{Celsius}°C";
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Ford", "Focus", 2018);
        Console.WriteLine(car);

        Temperature temp = new Temperature(20);
        Console.WriteLine(temp);
        Console.WriteLine($"{temp.Fahrenheit}°F");
    }
}