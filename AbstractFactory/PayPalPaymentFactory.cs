using System;

namespace AbstractFactory;

public class PayPalPaymentFactory:IPaymentFactory
{
      public IPaymentAuthorization CreateAuthorization() => new PayPalAuthorization();
  public IPaymentTransfer CreateTransfer() => new PayPalTransfer();
}
