namespace DIP
{
  public class Notification
  {

    private Gmail _gmail = new Gmail();
    private HotMail _hotMail = new HotMail();

    public string? address { get; set; }
    public string? message { get; set; }

    public string sendGmail()
    {
      _gmail.address = address;
      _gmail.message = message;
      return _gmail.Send();
    }

    public string sendHotMail()
    {
      _hotMail.address = address;
      _hotMail.message = message;
      return _hotMail.Send();
    }
  }
}