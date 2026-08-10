# Method

Method, belirli bir işi gerçekleştirmek için kullanılan kod bloğudur.

## Örnek

```csharp
void SayHello()
{
    Console.WriteLine("Merhaba");
}
```

Bu method çağrıldığında `Merhaba` yazdırır.

```csharp
SayHello();
```

## Gerçek Hayat Örneği

```csharp
void CancelOrder()
{
    Console.WriteLine("Sipariş iptal edildi.");
}
```

Bu method sipariş iptal işlemini temsil ediyor.

## BA Açısından

Bir method gördüğümüzde:

> "Bu kod hangi business işlemini gerçekleştiriyor?"

diye düşünmeliyiz.

Method isimleri genellikle yapılan işlemi anlamamıza yardımcı olur.

Örneğin:

* `CreateOrder()` → Sipariş oluştur
* `CancelOrder()` → Siparişi iptal et
* `CalculateDiscount()` → İndirimi hesapla
* `ProcessPayment()` → Ödemeyi işle
