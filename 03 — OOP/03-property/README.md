# Property (Özellik)

Property, bir class içerisindeki verilerin tanımlanmasını ve kullanılmasını sağlar.

## Örnek

```csharp id="a5x6r9"
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

Burada:

* `Name` → Ürün adı
* `Price` → Ürün fiyatı

birer property'dir.

## Property Kullanımı

```csharp id="yd1t2q"
Product product = new Product();

product.Name = "Laptop";
product.Price = 25000;
```

Property'nin değerini okuyabiliriz:

```csharp id="8q2l6d"
Console.WriteLine(product.Name);
```

## get ve set

```csharp id="w4qj7r"
public string Name { get; set; }
```

* `get` → Değeri okumaya izin verir.
* `set` → Değeri değiştirmeye izin verir.

## BA Açısından

Property'ler bir business nesnesinin hangi bilgilere sahip olduğunu anlamamıza yardımcı olur.

Örneğin:

```csharp id="p0g1u6"
class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
}
```

Buradan Customer'ın:

* Ad
* E-posta

bilgilerine sahip olduğunu anlayabiliriz.
