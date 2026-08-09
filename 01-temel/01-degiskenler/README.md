# Değişkenler

Değişkenler, program içerisinde veri saklamak için kullanılır.

## Temel Yapı

```csharp
string customerName = "Sude";
```

* `string` → veri tipi
* `customerName` → değişken adı
* `"Sude"` → değer

## Temel Veri Tipleri

| Veri Tipi | Kullanım                 |
| --------- | ------------------------ |
| string    | Metin                    |
| int       | Tam sayı                 |
| decimal   | Ondalıklı / parasal sayı |
| bool      | True / False             |

## Örnek

```csharp
string customerName = "Sude";
int customerAge = 28;
decimal orderTotal = 1250.50m;
bool isActive = true;
```

## BA Açısından

Değişken isimleri sistemdeki iş kavramları hakkında bilgi verebilir.

Örneğin:

```csharp
decimal minimumOrderAmount = 500;
```

Bu kod, sistemde minimum sipariş tutarı ile ilgili bir değer bulunduğunu gösterir.

Bu değer bir business rule olabilir ancak gereksinimlerle doğrulanmalıdır.

