using Microsoft.VisualBasic;

public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(double amount);
    public void ValidatePayment()
    {
        Console.WriteLine("Payment validation in progress...");
    }
    public PaymentProcessor()
    {
        
    }
}
public interface IPaymentSecurity
{
    void ApplySecurityCheck();
}
public class CreditCardPayment : PaymentProcessor, IPaymentSecurity
{
    public override void ProcessPayment(double amount)
    {
        ValidatePayment();
        ApplySecurityCheck();
        Console.WriteLine("Payment Complete, €{0} has been removed from your account, thank you for shopping with us!", amount);
    }
    public void ApplySecurityCheck()
    {
        Console.WriteLine("Credit card security check applied");
    }
}
public class PayPalPayment : PaymentProcessor, IPaymentSecurity
{
    public override void ProcessPayment(double amount)
    {
        ValidatePayment();
        ApplySecurityCheck();
        Console.WriteLine("Payment Complete, €{0} has been removed from your account, thank you for shopping with us!", amount);
    }
    public void ApplySecurityCheck()
    {
        Console.WriteLine("PayPal security check applied");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        CreditCardPayment ccp = new CreditCardPayment();
        PayPalPayment ppp = new PayPalPayment();
        ccp.ProcessPayment(249.99);
        ppp.ProcessPayment(50);
    }
}
