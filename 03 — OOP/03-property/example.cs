class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}

Product product = new Product();

product.Name = "Laptop";
product.Price = 25000;
product.Stock = 10;

Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
Console.WriteLine(product.Stock);
