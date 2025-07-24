using System;

namespace PaymentGatewaysIntergration;

public interface IPaymentGateWay
{
  void ProcessPayment(decimal amount);
}
