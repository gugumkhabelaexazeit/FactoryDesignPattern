using System;

namespace AbstractFactory;

public interface IPaymentFactory
{
    IPaymentAuthorization CreateAuthorization();
    IPaymentTransfer CreateTransfer();
}
