using System;

namespace AbstractFactory;

public interface IPaymentAuthorization
{
          bool AuthorizePayment(decimal amount);
}
