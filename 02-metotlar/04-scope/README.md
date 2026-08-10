# Scope (Kapsam)

Scope, bir değişkenin nerede kullanılabileceğini belirler.

## Method İçerisindeki Değişken

```csharp
void CalculateTotal()
{
    decimal total = 1000;

    Console.WriteLine(total);
}
```

`total` değişkeni sadece `CalculateTotal` metodu içerisinde kullanılabilir.

## Blok İçerisindeki Değişken

```csharp
if (true)
{
    string message = "Sipariş başarılı.";
    Console.WriteLine(message);
}
```

`message` değişkeni sadece `if` bloğu içerisinde kullanılabilir.

## Önemli

Bir değişken oluşturulduğu scope'un dışında kullanılamaz.

```csharp
if (true)
{
    int stock = 10;
}

Console.WriteLine(stock); // Hata
```

Çünkü `stock` sadece `if` bloğunun içerisinde tanımlıdır.

## BA Açısından

Scope, bir bilginin sistemin hangi bölümünde kullanılabildiğini anlamamıza yardımcı olur.

Örneğin bir değişken sadece ödeme metodunda kullanılıyorsa, bu bilginin ödeme işlemiyle sınırlı olduğunu düşünebiliriz.
