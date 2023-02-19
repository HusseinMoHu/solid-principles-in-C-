namespace DIP
{
  public class Gmail : IMessage
  {

    public string address { get; set; }
    public string message { get; set; }

    public Gmail(String aAddress, String aMessage)
    {
      address = aAddress;
      message = aMessage;
    }

    public string Send()
    {
      return "Gmail send to: " + address + " with message: " + message;
    }
  }

  public class HotMail : IMessage
  {
    public string address { get; set; }
    public string message { get; set; }

    public HotMail(String aAddress, String aMessage)
    {
      address = aAddress;
      message = aMessage;
    }

    public string Send()
    {
      return "HotMail send to: " + address + " with message: " + message;
    }
  }
}