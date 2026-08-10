class Product
{
    public string Name;
    public decimal Price;
}

Product product = new Product();

product.Name = "Laptop";
product.Price = 25000;

Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
