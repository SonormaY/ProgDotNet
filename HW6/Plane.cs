namespace HW6;

class Plane : GenericVehicle<Plane>, IPassengerTransport<int>, ICargoTransport<int>
{

    public Plane(int speed = 0, int passengers = 0, string name = "", Plane vehicleType =null): base(speed, passengers, name, vehicleType)
    {
    }
    public void TakeOff()
    {
        Console.WriteLine($"The {Name} is taking off.");
    }
    public void Display()
    {
        Console.WriteLine($"The {Name} is a {base.VehicleType.GetType}.");
    }
    public void Land()
    {
        Console.WriteLine($"The {Name} is landing.");
    }
    public void LoadPassengers(int passengers)
    {
        Console.WriteLine($"The {Name} is loading {passengers} passengers.");
    }
    public void UnloadPassengers(int passengers)
    {
        Console.WriteLine($"The {Name} is unloading {passengers} passengers.");
    }
    public void LoadCargo(int cargo)
    {
        Console.WriteLine($"The {Name} is loading {cargo} cargo.");
    }
    public void UnloadCargo(int cargo)
    {
        Console.WriteLine($"The {Name} is unloading {cargo} cargo.");
    }
}