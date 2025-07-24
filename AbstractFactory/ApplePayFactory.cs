using System;

namespace AbstractFactory;

public class ApplePayFactory : IPaymentFactory
{
  public IPaymentAuthorization CreateAuthorization() => new ApplePayAuthorization();

  IPaymentTransfer IPaymentFactory.CreateTransfer() => new ApplePayTransfer();
  
}
