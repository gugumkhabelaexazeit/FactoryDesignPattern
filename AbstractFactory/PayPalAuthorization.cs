using System;

namespace AbstractFactory;

public class PayPalAuthorization:IPaymentAuthorization
{
  public bool AuthorizePayment(decimal amount)
  {
    Console.WriteLine($"Authorizing payment of {amount} via PayPal...");
    return true; 
  }


}

public class PayPalTransfer : IPaymentTransfer
    {
        public bool Transfer(decimal amount)
        {
            Console.WriteLine($"Transferring payment of {amount} via PayPal...");
            return true; // Mocked success
        }
    }