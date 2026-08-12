# Constructor

Constructor, bir class'tan yeni bir nesne oluşturulduğunda otomatik olarak çalışan özel yapıdır.

Constructor'ın adı class ile aynıdır.

## Örnek

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

Nesne oluştururken:

Product product = new Product("Laptop", 25000);

Burada Product nesnesi oluşturulurken constructor çalışır.

- `name` → Ürün adı
- `price` → Ürün fiyatı

## BA Açısından

Constructor, bir business nesnesi oluşturulurken hangi bilgilerin gerekli olduğunu anlamamıza yardımcı olur.

Örneğin:

Product("Laptop", 25000)

ifadesinden ürün oluşturulurken ürün adı ve fiyat bilgisinin gerektiğini anlayabiliriz.
