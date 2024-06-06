namespace StrategyPatternConsoleApp.PaymentStrategy
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("PayPal payment is processing...");
        }
    }
}