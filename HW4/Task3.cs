namespace HW4
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Employee : Person, IComparable, ICloneable
    {
        public string Company { get; set; }
        public double Salary { get; set; }

        public Employee(string name = "null", int age = 0, string company = "null", double salary = 0) : base(name, age)
        {
            Company = company;
            Salary = salary;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Employee otherEmployee = obj as Employee;
            if (otherEmployee == null)
            {
                throw new ArgumentException("Object is not an Employee");
            }
            return this.Salary.CompareTo(otherEmployee.Salary);               
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}