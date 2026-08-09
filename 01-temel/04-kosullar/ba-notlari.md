# BA Notları

Koşullar, kod içerisindeki karar mekanizmalarını gösterir.

Örneğin:

```csharp
if (stock > 0)
```

Business anlamı:

> Stok miktarı 0'dan büyükse ürün stokta kabul edilir.

Başka bir örnek:

```csharp
if (total >= 500)
```

Business anlamı:

> Sipariş tutarı 500 TL veya üzerindeyse indirim uygulanabilir.

BA olarak `if` gördüğümüzde şu soruları sorabiliriz:

* Bu koşul neden var?
* Eşik değer nereden geliyor?
* Koşul sağlanmazsa ne oluyor?
* Başka bir durum var mı?
* Bu kural tüm kullanıcılar için geçerli mi?
