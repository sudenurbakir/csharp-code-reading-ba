# Class (Sınıf)

Class, bir nesnenin hangi özelliklere ve davranışlara sahip olduğunu tanımlayan yapıdır.

Örneğin bir e-ticaret sisteminde `Product` adında bir class olabilir.

```csharp
class Product
{
    public string Name;
    public decimal Price;
}
```

Bu class, bir ürünün:

* `Name` → Adı
* `Price` → Fiyatı

olabileceğini tanımlar.

## Class ve Object Farkı

Class → Şablon

Object → Bu şablondan oluşturulan gerçek nesne

Örneğin:

```csharp
Product product = new Product();

product.Name = "Laptop";
product.Price = 25000;
```

Burada `Product` class, `product` ise oluşturulan object'tir.

## BA Açısından

Class'lar sistemdeki business kavramlarını temsil edebilir.

Örneğin:

* `Product` → Ürün
* `Customer` → Müşteri
* `Order` → Sipariş
* `Payment` → Ödeme

Kodda bir class gördüğümüzde:

> "Sistemde hangi business kavramı temsil ediliyor?"

diye düşünmeliyiz.
