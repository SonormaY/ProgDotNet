namespace Prac3;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("John", "email1@lee.com", 123124);

        Product product = new Product("Apple", 11032);
        Product product2 = new Product("Banana", 2532);

        ShoppingCart cartJohn = new ShoppingCart(user);

        cartJohn.ProductAdded += cartJohn.OnProductAdded;
        cartJohn.ProductRemoved += cartJohn.OnProductRemoved;

        cartJohn.AddProduct(product);
        cartJohn.AddProduct(product2);
        cartJohn.AddProduct(product);
        cartJohn.AddProduct(product2);

        cartJohn.RemoveProduct(product, 1);

        Console.WriteLine();
        Console.WriteLine(cartJohn);
        cartJohn.ChangeProductPrice((product) =>
        {
            if (user.TotalSpent > 1000)
            {
                return product.Price * 0.9;
            }
            return product.Price;
        }, product2);
        Console.WriteLine();
        Console.WriteLine(cartJohn);

    }
}