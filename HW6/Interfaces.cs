namespace HW6;

public interface IPassengerTransport<in T>
{
    public void LoadPassengers(T passengers);
    public void UnloadPassengers(T passengers);
}

public interface ICargoTransport<in T>
{
    public void LoadCargo(T cargo);
    public void UnloadCargo(T cargo);
}