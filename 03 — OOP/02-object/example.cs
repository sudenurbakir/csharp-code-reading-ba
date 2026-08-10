class Product
{
    public string Name;
    public decimal Price;
}

Product product1 = new Product();
Product product2 = new Product();

product1.Name = "Laptop";
product1.Price = 25000;

product2.Name = "Telefon";
product2.Price = 15000;

Console.WriteLine(product1.Name);
Console.WriteLine(product2.Name);
