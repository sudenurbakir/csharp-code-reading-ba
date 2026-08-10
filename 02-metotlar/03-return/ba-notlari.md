# BA Notları

`return`, bir metodun sonucunda hangi bilginin geri döndüğünü anlamamıza yardımcı olur.

Örneğin:

```csharp
decimal CalculateTotal(decimal price, int quantity)
{
    return price * quantity;
}
```

Burada:

* `price` → Ürün fiyatı
* `quantity` → Ürün adedi
* `price * quantity` → Toplam tutar
* `return` → Hesaplanan sonucu geri döndürür

### BA Yorumu

Business akışı:

> Fiyat + Adet → Toplam tutar hesaplanır → Sonuç geri döndürülür.

Kod okurken `return` gördüğümüzde:

> "Bu işlemin çıktısı ne?"

sorusunu sormalıyız.
