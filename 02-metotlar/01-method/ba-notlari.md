# BA Notları

Method, sistemde gerçekleştirilen bir işlemi temsil edebilir.

Örneğin:

```csharp
CreateOrder();
```

Business anlamı:

> Sipariş oluşturma işlemi gerçekleştiriliyor.

```csharp
CancelOrder();
```

Business anlamı:

> Sipariş iptal ediliyor.

### BA Olarak Dikkat

Method isimleri sistemdeki business işlemleri hakkında önemli bilgiler verebilir.

Örneğin:

`CalculateDiscount()`

→ İndirim hesaplama işlemi var.

`ValidateOrder()`

→ Sipariş doğrulama işlemi var.

`SendEmail()`

→ E-posta gönderme işlemi var.

Kod okurken methodun **ne yaptığını** ve **hangi business işlemini temsil ettiğini** anlamaya çalışmalıyız.
