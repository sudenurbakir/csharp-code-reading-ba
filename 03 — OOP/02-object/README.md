# Object (Nesne)

Object, bir class kullanılarak oluşturulan gerçek nesnedir.

## Örnek

Önce bir class oluşturulur:

```csharp
class Product
{
    public string Name;
    public decimal Price;
}
```

Sonra bu class'tan bir object oluşturulur:

```csharp
Product product = new Product();
```

Burada:

* `Product` → Class
* `product` → Object
* `new Product()` → Yeni bir Product nesnesi oluşturur.

Object'e değer verebiliriz:

```csharp
product.Name = "Laptop";
product.Price = 25000;
```

## Birden Fazla Object

Aynı class'tan birden fazla object oluşturulabilir.

```csharp
Product product1 = new Product();
Product product2 = new Product();

product1.Name = "Laptop";
product2.Name = "Telefon";
```

İkisi de `Product` class'ından oluşturulmuştur ancak farklı ürünleri temsil eder.

## BA Açısından

Class bir business kavramının şablonudur.

Object ise o kavramın sistemdeki gerçek örneğidir.

Örneğin:

`Product` → Ürün kavramı

`product1` → Laptop ürünü

`product2` → Telefon ürünü
