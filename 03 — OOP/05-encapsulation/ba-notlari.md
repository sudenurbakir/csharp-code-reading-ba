# BA Notları

Encapsulation, verilerin doğrudan değiştirilmesini kontrol etmeye yardımcı olur.

Örneğin:

public decimal Price { get; private set; }

Burada fiyat dışarıdan okunabilir ancak doğrudan değiştirilemez.

Fiyat değiştirmek için:

ChangePrice()

metodu kullanılır.

Bu metodun içerisinde:

if (newPrice > 0)

kontrolü bulunuyor.

### BA Açısından

Business rule:

> Ürün fiyatı 0 veya negatif olamaz.

BA olarak kodda bu tarz kontroller gördüğümüzde ilgili business rule'u tespit edebiliriz.
