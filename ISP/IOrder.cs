namespace SolidDemo.ISP
{
  public interface IOrder
  {

  }

  public interface ICashOrder : IOrder { void AddCashOrder(); void Complete(); }

  public interface IOnlinePaymentOrder : IOrder { void AddOnlinePaymentOrder(); }

  public interface ICreditOrder : IOrder { void AddCreditOrder(); }

}