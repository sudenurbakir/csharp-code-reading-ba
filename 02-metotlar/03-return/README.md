# Return

`return`, bir metodun ürettiği sonucu geri döndürmesini sağlar.

## Örnek

```csharp
int AddNumbers(int number1, int number2)
{
    return number1 + number2;
}
```

Bu metot iki sayıyı toplar ve sonucu geri döndürür.

```csharp
int result = AddNumbers(10, 20);
```

`result` değeri:

```text
30
```

## void ile farkı

```csharp
void SayHello()
{
    Console.WriteLine("Merhaba");
}
```

`void` → Değer döndürmez.

```csharp
int GetTotal()
{
    return 100;
}
```

`int` → Tam sayı döndürür.

## BA Açısından

Bir metotta `return` gördüğümüzde:

> "Bu işlem sonucunda sisteme hangi bilgi geri dönüyor?"

diye düşünmeliyiz.

Örneğin:

```csharp
decimal CalculateTotal(decimal price, int quantity)
{
    return price * quantity;
}
```

Business anlamı:

> Ürün fiyatı ve adedi kullanılarak toplam tutar hesaplanıyor ve sonuç geri döndürülüyor.
