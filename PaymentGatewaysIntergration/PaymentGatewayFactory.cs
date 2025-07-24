using System;

namespace PaymentGatewaysIntergration;

public class PaymentGatewayFactory

{
  public static IPaymentGateWay CreatePaymentGateway(string gatewayName)
  {
    switch (gatewayName.ToLower())
    {
      case "paypal":
        return new PayPal();
      case "apple pay":
        return new ApplePay();
        case "BitCoin":
        return new BitCoin();
                default:
                    throw new ArgumentException("Invalid payment gateway specified");
    }
    
  }
}
