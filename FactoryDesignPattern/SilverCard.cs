public class SilverCard : CreditCard
{
  public string GetCardType()
  {
    return "Silver";
  }

  public int GetCreditLimit()
  {
    return 1500;
  }
  public int GetAnnualCharge()
  {
    return 500;
   }
}