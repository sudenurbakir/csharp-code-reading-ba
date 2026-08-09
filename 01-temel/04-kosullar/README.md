# Koşullar

Koşullar, belirli bir durumun gerçekleşip gerçekleşmediğini kontrol eder.

## if

Koşul doğruysa kod çalışır.

```csharp
if (stock > 0)
{
    Console.WriteLine("Ürün stokta.");
}
```

## if / else

Koşul doğruysa `if`, yanlışsa `else` çalışır.

```csharp
if (stock > 0)
{
    Console.WriteLine("Ürün stokta.");
}
else
{
    Console.WriteLine("Ürün stokta yok.");
}
```

## if / else if / else

Birden fazla durum kontrol edilebilir.

```csharp
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
```

## BA Açısından

`if` yapıları genellikle business rule'ların kod içerisindeki karşılığıdır.

Örneğin:

```csharp
if (total >= 500)
{
    discount = 50;
}
```

Business anlamı:

> Sipariş tutarı 500 TL veya üzerindeyse 50 TL indirim uygulanır.
