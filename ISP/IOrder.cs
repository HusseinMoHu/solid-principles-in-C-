namespace SolidDemo.ISP
{

  public interface ICashOrder { void AddCashOrder(); void Complete(); }

  public interface IOnlinePaymentOrder { void AddOnlinePaymentOrder(); }

  public interface ICreditOrder { void AddCreditOrder(); }



  // When user wants to pay order with multiple payment methods, we can use this interface
  public interface IOrder : ICashOrder, IOnlinePaymentOrder, ICreditOrder
  {
    void MethodBelongsToIOrderOnly();
  }
}