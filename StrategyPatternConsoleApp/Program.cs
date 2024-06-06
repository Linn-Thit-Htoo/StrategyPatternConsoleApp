using StrategyPatternConsoleApp;
using StrategyPatternConsoleApp.PaymentStrategy;

var creditCardPayment = new PaymentProcessor(new CreditCardPaymentStrategy());
creditCardPayment.ProcessPayment(15.5m);

var payPalPayment = new PaymentProcessor(new PayPalPaymentStrategy());
payPalPayment.ProcessPayment(10.5m);