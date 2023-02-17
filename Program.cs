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


      var Emp1 = new Manager("1", "Hussein", 40000);
      Console.WriteLine(
        Emp1.ToString() + Environment.NewLine
        + "Bonus:" + Emp1.calHoursBonus(5).ToString()
      );

      var Emp2 = new Regular("2", "Ahmed", 40000);
      Console.WriteLine(
        Emp2.ToString() + Environment.NewLine
        + "Bonus:" + Emp2.calHoursBonus(5).ToString()
      );

    }
  }
}