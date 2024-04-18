using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading.Tasks.Dataflow;
namespace Prac3;

public delegate double ChangePrice(Product product);
public class ProductAddedEventArgs : EventArgs
{
    public Product Product { get; set; }
    public ProductAddedEventArgs(Product product)
    {
        Product = product;
    }
}
public class ProductRemovedEventArgs : EventArgs
{
    public Product Product { get; set; }
    public ProductRemovedEventArgs(Product product)
    {
        Product = product;
    }
}
public class ShoppingCart
{
    public User User { get; set; }
    public Dictionary<Product, int> Products { get; set; }
    public EventHandler<ProductAddedEventArgs> ProductAdded;
    public EventHandler<ProductRemovedEventArgs> ProductRemoved;

    public ShoppingCart(User user)
    {
        User = user;
        Products = new Dictionary<Product, int>();
    }

    public void AddProduct(Product product)
    {
        if (Products.ContainsKey(product))
        {
            Products[product]++;
        }
        else
        {
            Products.Add(product, 1);
        }
        ProductAdded?.Invoke(this, new ProductAddedEventArgs(product));
    }

    public void RemoveProduct(Product product, int Quantity = 0)
    {
        if (Products.ContainsKey(product))
        {
            if (Quantity <= 0)
            {
                Products.Remove(product);
            }
            else
            {
                Products[product] -= Quantity;
            }
        }
        ProductRemoved?.Invoke(this, new ProductRemovedEventArgs(product));
    }
    public void OnProductAdded(object sender, ProductAddedEventArgs e)
    {
        Console.WriteLine($"Product added: {e.Product}");
    }
    public void OnProductRemoved(object sender, ProductRemovedEventArgs e)
    {
        Console.WriteLine($"Product removed: {e.Product}");
    }
    public void ChangeProductPrice(ChangePrice changePrice, Product product)
    {
        foreach (Product p in Products.Keys)
        {
            product.Price = changePrice(product);
        }
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.Key.Price * product.Value;
        }
        return totalPrice;
    }

    public void SortByPrice()
    {
        Products = Products.OrderBy(x => x.Key.Price).ToDictionary(x => x.Key, x => x.Value);
    }

    public void SortByName(bool desc = false)
    {
        if (!desc)
        {
            Products = Products.OrderBy(x => x.Key.Name).ToDictionary(x => x.Key, x => x.Value);
        }
        else
        {
            Products = Products.OrderByDescending(x => x.Key.Name).ToDictionary(x => x.Key, x => x.Value);
        }
    }

    public override string ToString()
    {
        StringBuilder lines = new StringBuilder();
        foreach (Product product in Products.Keys)
        {
            lines.AppendLine(product.ToString() + $" Quantity: {Products[product]}");
        }
        return $"User: {User}\nProducts:\n{lines}Total Price: {GetTotalPrice()}";
    }
}