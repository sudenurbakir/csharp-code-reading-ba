# Veri Tipleri

Veri tipi, bir değişkende hangi türde veri tutulacağını belirtir.

## Temel Veri Tipleri

| Veri Tipi | Açıklama                 | Örnek      |
| --------- | ------------------------ | ---------- |
| `string`  | Metin                    | `"Ahmet"`  |
| `int`     | Tam sayı                 | `25`       |
| `decimal` | Ondalıklı / parasal sayı | `1250.50m` |
| `double`  | Ondalıklı sayı           | `10.5`     |
| `bool`    | Doğru veya yanlış        | `true`     |
| `char`    | Tek karakter             | `'A'`      |

## Örnek

```csharp
string productName = "Laptop";
int stock = 25;
decimal price = 24999.99m;
double rating = 4.5;
bool isAvailable = true;
char categoryCode = 'E';
```

## BA Açısından

Veri tipi, sistemde tutulan bilginin türü hakkında fikir verir.

Örneğin:

```csharp
decimal price = 24999.99m;
```

Burada `price` değişkeninin parasal bir değer tuttuğunu anlayabiliriz.

```csharp
bool isAvailable = true;
```

Burada ürünün mevcut olup olmadığı bilgisinin tutulduğunu anlayabiliriz.
