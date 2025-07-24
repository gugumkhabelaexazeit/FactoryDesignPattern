public class CreditCardFactory
{
  public static CreditCard GetCreditCard(string cardType)
  {
    CreditCard cardDetails = null;

    if (cardType == "Platinum")
    {
      cardDetails = new Platinum();
    }
    else if (cardType == "Silver")
    {
      cardDetails = new SilverCard();
    }
    else if (cardType == "Gold")
    {
      cardDetails = new GoldCard();
    }
    return cardDetails;
  }
}
