namespace DIP
{
  public class Gmail
  {
    public string? address { get; set; }
    public string? message { get; set; }

    public string Send()
    {
      return "Gmail send to " + address + " with message " + message;
    }
  }

  public class HotMail
  {
    public string? address { get; set; }
    public string? message { get; set; }

    public string Send()
    {
      return "HotMail send to " + address + " with message " + message;
    }
  }
}