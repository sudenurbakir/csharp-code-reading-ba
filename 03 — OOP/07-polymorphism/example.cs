
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

Payment payment1 = new CreditCardPayment();
Payment payment2 = new BankTransferPayment();

payment1.Pay();
payment2.Pay();
