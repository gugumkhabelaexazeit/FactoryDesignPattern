using System;

namespace PaymentGatewaysIntergration;

public class PayPal: IPaymentGateWay
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Processing ${amount} payment through PayPal...");
  }
  

}

