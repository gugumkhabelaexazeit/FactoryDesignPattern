using PaymentGatewaysIntergration;

public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Select the payment gateway (PayPal, ApplePay, BitCoin: ");
            string gatewayName = Console.ReadLine();
            try
            {
              IPaymentGateWay paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
                paymentGateway.ProcessPayment(100.00M);  
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }