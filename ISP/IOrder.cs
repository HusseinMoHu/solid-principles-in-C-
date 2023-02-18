namespace SolidDemo.ISP
{
  public interface IOrder
  {
    void AddInvoice();
  }

  public interface ICashOrder : IOrder { void AddCashOrder(); }

  public interface IOnlinePaymentOrder : IOrder { void AddOnlinePaymentOrder(); }

  public interface ICreditOrder : IOrder { void AddCreditOrder(); }

}