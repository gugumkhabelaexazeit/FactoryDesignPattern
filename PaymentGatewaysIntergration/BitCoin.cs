using System;

namespace PaymentGatewaysIntergration;

public class BitCoin:IPaymentGateWay
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Processing ${amount} payment using Credit BitCoin...");
  }
}
