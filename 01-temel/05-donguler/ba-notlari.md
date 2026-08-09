# BA Notları

Döngü gördüğümüzde temel olarak şunu düşünmeliyiz:

> Birden fazla veri üzerinde aynı işlem mi yapılıyor?

Örneğin:

```csharp
foreach (string product in products)
```

Burada `products` içerisindeki ürünler tek tek ele alınıyor.

### BA Açısından

Döngüler şu işlemlerde karşımıza çıkabilir:

* Ürünleri kontrol etmek
* Siparişleri işlemek
* Müşterileri listelemek
* Stokları kontrol etmek
* Birden fazla kayda işlem uygulamak

Özellikle `foreach` gördüğümüzde:

> "Sistemdeki bir veri listesinin elemanları tek tek işleniyor."

şeklinde okuyabiliriz.
