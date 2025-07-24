using System;

namespace PaymentGatewaysIntergration;

public class ApplePay:IPaymentGateWay
{
   public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Processing ${amount} payment through ApplePay...");
  }
}
