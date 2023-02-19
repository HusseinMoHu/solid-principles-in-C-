namespace DIP
{
  public class Notification
  {

    private readonly IMessage _mailService;

    public Notification(IMessage mailService)
    {
      // Dependency Injection
      _mailService = mailService;
    }


    public string SendMail()
    {
      return _mailService?.Send() ?? "No mail service";
    }

  }
}