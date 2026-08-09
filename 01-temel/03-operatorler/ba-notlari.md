# BA Notları

Operatörler, kod içerisindeki business rule'ları anlamamıza yardımcı olabilir.

Örneğin:

```csharp
if (total >= 500)
```

Buradan şu business rule çıkarılabilir:

> Sipariş tutarı 500 TL veya üzerindeyse koşul sağlanır.

Başka bir örnek:

```csharp
if (stock > 0 && isActive == true)
```

Burada iki koşul vardır:

1. Stok 0'dan büyük olmalı.
2. Ürün aktif olmalı.

Business anlamı:

> Stokta bulunan ve aktif olan ürün satışa sunulabilir.

BA olarak operatörleri gördüğümüzde özellikle `if` koşullarına ve kullanılan karşılaştırmalara dikkat etmeliyiz.
