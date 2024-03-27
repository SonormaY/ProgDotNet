namespace HW6;

class Car : GenericVehicle<Car>, IPassengerTransport<int>
{
    public string Brand { get; set; }
    public Car(int speed = 0, int passengers = 0, string name = "", Car vehicleType = null, string brand = "") : base(speed, passengers, name, vehicleType)
    {
        Brand = brand;
    }
    public void Display()
    {
        Console.WriteLine($"The {Name}({Brand}) is a {base.VehicleType.GetType}.");
    }
    public void OpenTrunk()
    {
        Console.WriteLine($"The {Name}({Brand}) trunk is open.");
    }
    public void CloseTrunk()
    {
        Console.WriteLine($"The {Name}({Brand}) trunk is closed.");
    }
    public void LoadPassengers(int passengers)
    {
        Console.WriteLine($"The {Name}({Brand}) is loading {passengers} passengers.");
    }
    public void UnloadPassengers(int passengers)
    {
        Console.WriteLine($"The {Name}({Brand}) is unloading {passengers} passengers.");
    }
}