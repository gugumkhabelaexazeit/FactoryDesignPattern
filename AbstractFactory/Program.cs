using AbstractFactory;

public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Processing payment using Credit Card:");
            var applepayFactory = new ApplePayFactory();
            var applePayProcessor = new PaymentProcessor(applepayFactory);
            applePayProcessor.ProcessPayment(100.00M);

            Console.WriteLine("\nProcessing payment using PayPal:");
            var payPalFactory = new PayPalPaymentFactory();
            var payPalProcessor = new PaymentProcessor(payPalFactory);
            payPalProcessor.ProcessPayment(100.00M);
            Console.ReadKey();
        }
    }