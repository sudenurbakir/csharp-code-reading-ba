# Polymorphism (Çok Biçimlilik)

Polymorphism, farklı class'ların aynı metot veya yapıyı farklı şekilde uygulayabilmesini sağlar.

Kısaca:

> Aynı işlem, farklı nesnelerde farklı şekilde çalışabilir.

## Örnek

Bir ödeme sistemi düşünelim:

- CreditCardPayment
- BankTransferPayment
- CashPayment

Hepsinde `Pay()` isimli bir metot olabilir. Ancak ödeme yöntemi değiştiğinde işlemin nasıl yapılacağı da değişebilir.

```csharp
class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Ödeme yapıldı.");
    }
}

class CreditCardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Kredi kartı ile ödeme yapıldı.");
    }
}

class BankTransferPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Banka transferi ile ödeme yapıldı.");
    }
}
