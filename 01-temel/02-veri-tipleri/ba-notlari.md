# BA Notları

## Veri Tipini Okuma

Kodda bir veri tipi gördüğümüzde, verinin ne tür bir bilgi olduğunu anlamaya çalışabiliriz.

### Örnek

```csharp
int stock = 25;
```

* `int` → tam sayı
* `stock` → stok miktarı
* `25` → mevcut değer

BA açısından:

> Sistemde ürün stok miktarı tutuluyor.

---

```csharp
decimal price = 24999.99m;
```

BA açısından:

> Sistemde ürün fiyatı tutuluyor.

---

```csharp
bool isAvailable = true;
```

BA açısından:

> Ürünün satışa uygun olup olmadığı bilgisi tutuluyor.

## Dikkat

Değişkenin adı bize business anlamı verirken, veri tipi bize verinin teknik yapısı hakkında bilgi verir.
