namespace HW4
{
    interface IVehicle
    {
        void Drive();
    }

    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle is driving");
        }
    }
}
