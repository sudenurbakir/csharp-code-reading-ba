# Parametre

Parametre, bir methodun dışarıdan bilgi almasını sağlar.

## Örnek

```csharp
void GreetCustomer(string customerName)
{
    Console.WriteLine($"Merhaba {customerName}");
}
```

Burada:

* `string` → veri tipi
* `customerName` → parameter

Methodu çağırırken değer gönderilir:

```csharp
GreetCustomer("Ahmet");
```

Sonuç:

```text
Merhaba Ahmet
```

## Birden Fazla Parameter

```csharp
void CalculateTotal(decimal price, int quantity)
{
    decimal total = price * quantity;
    Console.WriteLine(total);
}
```

Çağırma:

```csharp
CalculateTotal(100, 3);
```

Sonuç:

```text
300
```

## BA Açısından

Parametre, bir business işleminin hangi bilgilere ihtiyaç duyduğunu gösterir.

Örneğin:

```csharp
CalculateTotal(decimal price, int quantity)
```

Bu methodun hesaplama yapabilmek için:

* Ürün fiyatına
* Ürün adedine

ihtiyaç duyduğunu anlayabiliriz.
