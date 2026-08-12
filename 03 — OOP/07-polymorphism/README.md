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

virtual → Metodun alt class'larda değiştirilebileceğini belirtir.
override → Alt class'ın metodu kendi davranışıyla yeniden tanımladığını belirtir.

Kullanım;

Payment payment1 = new CreditCardPayment();
Payment payment2 = new BankTransferPayment();

payment1.Pay();
payment2.Pay();

Sonuç:

Kredi kartı ile ödeme yapıldı.
Banka transferi ile ödeme yapıldı.

**BA Açısından**

Aynı business işleminin farklı senaryolara göre farklı şekilde gerçekleştirildiğini gösterebilir.

Örneğin:

Payment
├── CreditCardPayment
├── BankTransferPayment
└── CashPayment

Hepsi "Ödeme yapma" işlemini gerçekleştirir ancak yöntemleri farklıdır.

BA Olarak Sorulabilecek Sorular
Hangi ödeme yöntemleri destekleniyor?
Her ödeme yönteminin farklı kuralları var mı?
Ödeme başarısız olduğunda ne oluyor?
Yeni bir ödeme yöntemi eklenebilir mi?
