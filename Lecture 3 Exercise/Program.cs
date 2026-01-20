using Microsoft.VisualBasic;

public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(float amount);
    public void ValidatePayment()
    {
        Console.WriteLine("Payment validation in progress...");
    }
}
public interface IPaymentSecurity
{
    void ApplySecurityCheck();
}
public class CreditCardPayment : PaymentProcessor, IPaymentSecurity
{
    public void ProcessPayment()
    {
        ValidatePayment();
        ApplySecurityCheck();
        Console.WriteLine("Payment Complete, €{0} has been removed from your account, thank you for shopping with us!");
    }
    public void ApplySecurityCheck()
    {
        Console.WriteLine("Credit Card Security Check Applied");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        
    }
}
