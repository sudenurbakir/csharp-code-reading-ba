# BA Notları

Parametre, bir işlemin gerçekleştirilmesi için gereken bilgileri gösterir.

Örneğin:

```csharp
void CalculateTotal(decimal price, int quantity)
```

Buradan:

> Toplam hesaplamak için ürün fiyatı ve ürün adedi gerekiyor.

sonucunu çıkarabiliriz.

### BA Olarak Sorulabilecek Sorular

* Fiyat hangi kaynaktan geliyor?
* Adet 0 olabilir mi?
* Negatif adet olabilir mi?
* İndirim hesaplamaya dahil mi?
* Vergi hesaplamaya dahil mi?

Parameter'ları okurken methodun hangi business verilerine ihtiyaç duyduğunu anlamaya çalışmalıyız.
