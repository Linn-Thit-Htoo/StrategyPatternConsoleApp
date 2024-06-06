namespace StrategyPatternConsoleApp.PaymentStrategy;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Credit Card payment is processing...");
    }
}