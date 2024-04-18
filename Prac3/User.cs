namespace Prac3;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public double TotalSpent { get; set; }

    public User(string name, string email, double totalSpent)
    {
        Name = name;
        Email = email;
        TotalSpent = totalSpent;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Email: {Email}, Balance: {TotalSpent}";
    }
}