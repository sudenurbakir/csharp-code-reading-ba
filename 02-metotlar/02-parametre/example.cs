void GreetCustomer(string customerName)
{
    Console.WriteLine($"Merhaba {customerName}");
}

void CalculateTotal(decimal price, int quantity)
{
    decimal total = price * quantity;
    Console.WriteLine($"Toplam: {total}");
}

GreetCustomer("Ahmet");
CalculateTotal(100, 3);
