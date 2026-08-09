# Döngüler

Döngüler, bir işlemi birden fazla kez çalıştırmak için kullanılır.

## for

Belirli sayıda tekrar yapmak için kullanılır.

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

Bu kod 0'dan 4'e kadar çalışır.

## foreach

Bir listedeki elemanların tamamını tek tek dolaşmak için kullanılır.

```csharp
string[] products = { "Laptop", "Telefon", "Tablet" };

foreach (string product in products)
{
    Console.WriteLine(product);
}
```

## while

Bir koşul doğru olduğu sürece çalışır.

```csharp
int stock = 5;

while (stock > 0)
{
    Console.WriteLine(stock);
    stock--;
}
```

## BA Açısından

Döngüler genellikle sistemdeki birden fazla kaydın işlenmesinde kullanılır.

Örneğin:

```csharp
foreach (string product in products)
{
    Console.WriteLine(product);
}
```

Business anlamı:

> Sistemdeki ürünler tek tek işleniyor.

Gerçek projelerde bu; ürünleri kontrol etmek, siparişleri işlemek veya müşterileri listelemek gibi işlemlerde kullanılabilir.
