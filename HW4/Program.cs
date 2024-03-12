namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Task 1
            Console.WriteLine("----------");
            Console.WriteLine("| Task 1 |");
            Console.WriteLine("----------");
            var car = new Car();
            car.Drive();
            var motorcycle = new Motorcycle();
            motorcycle.Drive();
            Console.WriteLine("----------");

            // Task 2
            Console.WriteLine("| Task 2 |");
            Console.WriteLine("----------");
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine("----------");

            // Task 3
            Console.WriteLine("| Task 3 |");
            Console.WriteLine("----------");
            Employee employee1 = new Employee("John", 25, "Microsoft", 1000);
            Employee employee2 = new Employee("Bill", 30, "Apple", 2000);
            var result = employee1.CompareTo(employee2);
            if (result > 0)
            {
                Console.WriteLine(employee1.Name + " has a bigger salary than " + employee2.Name);
            }
            else if (result < 0)
            {
                Console.WriteLine(employee1.Name + " has a smaller salary than " + employee2.Name);
            }
            else
            {
                Console.WriteLine(employee1.Name + " has the same salary as " + employee2.Name);
            }
            Employee employee3 = (Employee)employee1.Clone();
            Console.WriteLine(employee3.Name);
            Console.WriteLine("----------");

            // Task 4
            Console.WriteLine("| Task 4 |");
            Console.WriteLine("----------");
            Vector v1 = new Vector(1, 2);
            Vector v2 = new Vector(3, 4);
            Vector v3 = v1 + v2;
            Console.WriteLine(v3.X + " " + v3.Y);
        }
    }
}