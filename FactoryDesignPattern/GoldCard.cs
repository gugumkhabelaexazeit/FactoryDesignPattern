public class GoldCard : CreditCard
{
  public string GetCardType()
  {
    return "GoldCard";
  }

  public int GetCreditLimit()
  {
    return 25000;
  }
  public int GetAnnualCharge()
  {
    return 1500;
   }
}