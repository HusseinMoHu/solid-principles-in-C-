using System;
using System.Collections.Generic;
using System.Linq;


// Change the namespace based on concept folder namespace
namespace OpenClosedPrinciple
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // EMP1
      var Emp1 = new Manager();
      Emp1.ID = "1";
      Emp1.Name = "Hussein";
      Emp1.BasicSalary = 40000;

      Console.WriteLine(
        Emp1.ToString() + Environment.NewLine
        + "Bonus:" + Emp1.calHoursBonus(5).ToString()
      );
    }
  }
}