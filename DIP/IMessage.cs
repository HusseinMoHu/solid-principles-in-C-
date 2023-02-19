namespace DIP
{
  public interface IMessage
  {
    string address { get; set; }
    string message { get; set; }
    string Send();
  }
}