decimal total = 1000;
decimal discount = 100;

decimal finalPrice = total - discount;

int stock = 10;
bool isActive = true;

if (stock > 0 && isActive == true)
{
    Console.WriteLine("Ürün satışta.");
}

Console.WriteLine(finalPrice);
