public class Program
{
  public static void Main(string[] args)
  {

    DIP.Notification notification1 = new DIP.Notification(new DIP.Gmail("hussein@gmail.com", "Hello From Gmail"));
    Console.WriteLine(notification1.SendMail());

    DIP.Notification notification2 = new DIP.Notification(new DIP.HotMail("hussein@hotmail.com", "Hello From HotMail"));
    Console.WriteLine(notification2.SendMail());
  }
}
