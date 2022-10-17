
class Program
{
    static void Main(string[] args)
    {
        var paymentInfo = new PaymentInfo
        {
            AccountHolderIban = "TR12345",
            AccountHolderName = "Mustafa Korkmaz",
            CreditCardNumber = "MasterCard12345"
        };

        var factory = new PaymentFactory();

        var stripePayment = factory.GetPayment(PaymentOption.Stripe);
        var payPalPayment = factory.GetPayment(PaymentOption.PayPal);

        stripePayment.DoPayment(paymentInfo); // Stripe payment completed for Mustafa Korkmaz by using card MasterCard12345
        payPalPayment.DoPayment(paymentInfo); // PayPal money transfer completed. Account Holder: Mustafa Korkmaz, IBAN: TR12345
    }
}

abstract class Payment
{
    public abstract void DoPayment(PaymentInfo paymentInfo);
}

class PaymentInfo
{
    public string? AccountHolderName { get; set; }
    public string? AccountHolderIban { get; set; }
    public string? CreditCardNumber { get; set; }
}

enum PaymentOption
{
    Stripe, PayPal
}

class StripePayment : Payment
{
    public override void DoPayment(PaymentInfo paymentInfo)
    {
        Console.WriteLine($"Stripe payment completed for {paymentInfo.AccountHolderName} by using card {paymentInfo.CreditCardNumber}");
    }
}

class PayPalPayment : Payment
{
    public override void DoPayment(PaymentInfo paymentInfo)
    {
        Console.WriteLine($"PayPal money transfer completed. Account Holder: {paymentInfo.AccountHolderName}, IBAN: {paymentInfo.AccountHolderIban}");
    }
}
class PaymentFactory
{
    // Factory method
    public Payment GetPayment(PaymentOption paymentOption)
    {
        switch (paymentOption)
        {
            case PaymentOption.Stripe:
                return new StripePayment();
            case PaymentOption.PayPal:
                return new PayPalPayment();
            default:
                throw new ArgumentOutOfRangeException(nameof(paymentOption), paymentOption, null);
        }
    }
}