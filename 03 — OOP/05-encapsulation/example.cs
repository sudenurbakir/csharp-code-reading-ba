class Product
{
    public decimal Price { get; private set; }

    public void ChangePrice(decimal newPrice)
    {
        if (newPrice > 0)
        {
            Price = newPrice;
        }
    }
}

Product product = new Product();

product.ChangePrice(25000);

Console.WriteLine(product.Price);
