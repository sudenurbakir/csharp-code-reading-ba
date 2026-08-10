# BA Notları

Class'lar, gerçek hayattaki business kavramlarının kod içerisindeki karşılığı olabilir.

Örneğin:

```csharp
class Product
{
    public string Name;
    public decimal Price;
}
```

Burada sistemde `Product` yani **Ürün** kavramının bulunduğunu anlıyoruz.

Ürünün:

* Adı
* Fiyatı

bilgileri tutuluyor.

### BA Açısından Sorulabilecek Sorular

* Ürünün başka hangi bilgileri var?
* Fiyat nasıl belirleniyor?
* Ürün hangi durumlarda satışa açık?
* Stok bilgisi nerede tutuluyor?
* Ürün hangi kategoriye bağlı?

Class'ları okurken öncelikle hangi business nesnesini temsil ettiğini anlamaya çalışmalıyız.

Class (Sınıf): Nesnelerin özelliklerini tanımlayan şablondur.
Object (Nesne): Class kullanılarak oluşturulan gerçek nesnedir.
new: Yeni bir nesne oluşturmak için kullanılır.
public: Özelliğin dışarıdan erişilebilir olduğunu belirtir.
product.Name: Nesnenin Name özelliğine erişir.
product.Price: Nesnenin Price özelliğine erişir.

Özet:
Class = Şablon
Object = Gerçek nesne
new = Yeni nesne oluştur
