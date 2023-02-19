public class Program
{
  public static void Main(string[] args)
  {

    DIP.Notification notification = new DIP.Notification();
    notification.address = "hussein@gmail.com";
    notification.message = "Hello World";
    Console.WriteLine(notification.sendGmail());
    Console.WriteLine(notification.sendHotMail());
  }
}
