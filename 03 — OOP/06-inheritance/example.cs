class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class ElectronicProduct : Product
{
    public int WarrantyMonths { get; set; }
}

ElectronicProduct product = new ElectronicProduct();

product.Name = "Laptop";
product.Price = 25000;
product.WarrantyMonths = 24;

Console.WriteLine(product.Name);
Console.WriteLine(product.Price);
Console.WriteLine(product.WarrantyMonths);
