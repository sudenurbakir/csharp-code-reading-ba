# BA Notları

Property'ler, bir business nesnesinin hangi bilgilere sahip olduğunu gösterir.

Örneğin:

```csharp id="kj6d8u"
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
```

Buradan:

> Ürün; ad, fiyat ve stok bilgilerine sahip.

sonucunu çıkarabiliriz.

### BA Açısından

Property'leri gördüğümüzde sistemde hangi verilerin tutulduğunu anlayabiliriz.

Örneğin:

`Name` → Ürün adı

`Price` → Ürün fiyatı

`Stock` → Ürün stok miktarı

Bu bilgiler gereksinimlerle karşılaştırılarak eksik veya fazla alanlar tespit edilebilir.
