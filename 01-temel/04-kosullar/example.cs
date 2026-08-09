decimal total = 750;
int stock = 5;
string paymentStatus = "Paid";

if (stock > 0)
{
    Console.WriteLine("Ürün stokta.");
}
else
{
    Console.WriteLine("Ürün stokta yok.");
}

if (total >= 500)
{
    Console.WriteLine("İndirim uygulanabilir.");
}

if (paymentStatus == "Paid")
{
    Console.WriteLine("Sipariş ödendi.");
}
else if (paymentStatus == "PartiallyPaid")
{
    Console.WriteLine("Sipariş kısmen ödendi.");
}
else
{
    Console.WriteLine("Sipariş ödenmedi.");
}
