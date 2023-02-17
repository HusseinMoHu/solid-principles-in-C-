using System;
using System.Collections.Generic;
using System.Linq;


// Change the namespace based on concept you are trying to demonstrate (SRP, OCP, LSP, ISP, DIP)
namespace SolidDemo.OCP
{
  public class Program
  {
    public static void Main(string[] args)
    {


      IEmployee Emp1 = new ManagerEmployee();
      Emp1.ID = "1";
      Emp1.Name = "Hussein";
      Emp1.BasicSalary = 40000;
      Console.WriteLine(
        Emp1.ToString() + Environment.NewLine
        + "Bonus:" + Emp1.calHoursBonus(5).ToString()
      );

      IEmployee Emp2 = new RegularEmployee();
      Emp2.ID = "2";
      Emp2.Name = "Ahmed";
      Emp2.BasicSalary = 40000;
      Console.WriteLine(
        Emp2.ToString() + Environment.NewLine
        + "Bonus:" + Emp2.calHoursBonus(5).ToString()
      );

    }
  }
}