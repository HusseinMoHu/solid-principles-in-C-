public class Program
{
  public static void Main(string[] args)
  {

    DIP.Gmail gmail = new DIP.Gmail() { address = "hussein@gmail.com", message = "Hello World" };
    DIP.Notification notification1 = new DIP.Notification(gmail);
    Console.WriteLine(notification1.SendMail());


    DIP.HotMail hotMail = new DIP.HotMail() { address = "hussein@hotmail.com", message = "Hello World" };
    DIP.Notification notification2 = new DIP.Notification(gmail);
    Console.WriteLine(notification2.SendMail());
  }
}
