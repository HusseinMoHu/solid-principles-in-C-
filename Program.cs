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
      var Emp1 = new Employee();
      Emp1.ID = "1";
      Emp1.Name = "Karim";
      Emp1.BasicSalary = 40000;
      Emp1.EmployeeType = EmployeesTypes.Manager;

      Console.WriteLine(
        Emp1.ToString() + Environment.NewLine
        + "Bonus:" + Emp1.calHoursBonus(5).ToString()
      );

      // EMP2
      var Emp2 = new Employee();
      Emp2.ID = "2";
      Emp2.Name = "Hussein";
      Emp2.BasicSalary = 7500;

      Console.WriteLine(
        Emp2.ToString() + Environment.NewLine
        + "Bonus:" + Emp2.calHoursBonus(5).ToString()
      );
    }
  }
}