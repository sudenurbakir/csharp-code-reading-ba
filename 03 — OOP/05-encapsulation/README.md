# Encapsulation (Kapsülleme)

Encapsulation, bir class içerisindeki verilerin doğrudan değiştirilmesini kontrol etmeyi sağlar.

Örneğin:

public class Product
{
    public decimal Price { get; private set; }

    public void ChangePrice(decimal newPrice)
    {
        if (newPrice > 0)
        {
            Price = newPrice;
        }
    }
}

Burada:

- `get` → Price değerini okumaya izin verir.
- `private set` → Price değerinin dışarıdan değiştirilmesini engeller.
- `ChangePrice()` → Fiyat değişikliğini kontrol eder.

## BA Açısından

Encapsulation, business rule'ların kod içerisinde uygulanmasını sağlayabilir.

Örneğin fiyatın 0 veya negatif olmasını engellemek bir business rule olabilir.
