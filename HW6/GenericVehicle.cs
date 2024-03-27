//1. Створити узагальнений клас ТранспортнийЗасіб, що містить загальні властивості 
//(наприклад: швидкість, кількість пасажирів тощо).

namespace HW6;

public class GenericVehicle<T>
{
    public int Speed { get; set; }
    public int Passengers { get; set; }
    public string Name { get; set; }
    public T VehicleType { get; set; }
    public GenericVehicle(int speed, int passengers, string name, T vehicleType)
    {
        Speed = speed;
        Passengers = passengers;
        Name = name;
        VehicleType = vehicleType;
    }
}