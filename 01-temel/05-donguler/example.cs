string[] products = { "Laptop", "Telefon", "Tablet" };

foreach (string product in products)
{
    Console.WriteLine(product);
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Ürün sırası: {i + 1}");
}

int stock = 3;

while (stock > 0)
{
    Console.WriteLine($"Stok: {stock}");
    stock--;
}
