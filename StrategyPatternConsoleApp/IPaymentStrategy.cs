namespace StrategyPatternConsoleApp;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}