# Operatörler

Operatörler, veriler üzerinde işlem yapmak veya karşılaştırma yapmak için kullanılır.

## Aritmetik Operatörler

| Operatör | Anlamı  |
| -------- | ------- |
| `+`      | Toplama |
| `-`      | Çıkarma |
| `*`      | Çarpma  |
| `/`      | Bölme   |

```csharp
decimal total = 1000;
decimal discount = 100;

decimal finalPrice = total - discount;
```

Sonuç: `900`

## Karşılaştırma Operatörleri

| Operatör | Anlamı              |
| -------- | ------------------- |
| `==`     | Eşit mi?            |
| `!=`     | Eşit değil mi?      |
| `>`      | Büyük mü?           |
| `<`      | Küçük mü?           |
| `>=`     | Büyük veya eşit mi? |
| `<=`     | Küçük veya eşit mi? |

Örnek:

```csharp
if (total >= 500)
{
    Console.WriteLine("Minimum tutar sağlandı.");
}
```

## Mantıksal Operatörler

| Operatör | Anlamı |   |      |
| -------- | ------ | - | ---- |
| `&&`     | VE     |   |      |
| `        |        | ` | VEYA |
| `!`      | DEĞİL  |   |      |

Örnek:

```csharp
if (stock > 0 && isActive == true)
{
    Console.WriteLine("Ürün satışta.");
}
```
