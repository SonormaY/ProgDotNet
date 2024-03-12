public class User
{
    public string Name { get; set; }
    public string Password { get; set; }

    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Password: {Password}";
    }
}

public class Program
{
    public static void Main()
    {
        User user = new User("John", "1234");
        Console.WriteLine(user);
    }
}