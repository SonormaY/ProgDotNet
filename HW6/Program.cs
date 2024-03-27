//1. Створити узагальнений клас ТранспортнийЗасіб, що містить загальні властивості (наприклад: швидкість, кількість пасажирів тощо).

//2. Узагальнити цей клас для конкретних видів транспорту, наприклад, Автомобіль, Автобус, Літак, Потяг тощо.

//3. Додати узагальнений інтерфейс МожливістьПеревезенняЛюдей та МожливістьПеревезенняВантажу.

//4. Реалізувати методи для керування транспортом (наприклад, розгін, гальмування) в залежності від виду транспорту. 

namespace HW6;

class Program
{
    static void Main()
    {
        Console.Clear();
        Car car = new Car(100, 4, "Name1", new Car(), "BMW");
        car.LoadPassengers(4);
        car.UnloadPassengers(4);
        car.OpenTrunk();
        car.CloseTrunk();
        Console.WriteLine();

        Plane plane = new Plane(500, 200, "Plane2", new Plane());
        plane.TakeOff();
        plane.LoadPassengers(200);
        plane.UnloadPassengers(200);
        plane.LoadCargo(1000);
        plane.UnloadCargo(1000);
        plane.Land();
    }
}
