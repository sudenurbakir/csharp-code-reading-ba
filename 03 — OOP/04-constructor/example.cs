class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

Product product = new Product("Laptop", 25000);

Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
