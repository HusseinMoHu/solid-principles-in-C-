namespace OpenClosedPrinciple
{
  public enum EmployeesTypes
  {
    Manager,
    Regular,
  };

  public abstract class Employee
  {
    public string ID;
    public string Name;
    public decimal BasicSalary;

    public Employee(string ID, string Name, decimal BasicSalary)
    {
      this.ID = ID;
      this.Name = Name;
      this.BasicSalary = BasicSalary;
    }

    public abstract decimal calHoursBonus(decimal hours);

    public override string ToString()
    {
      return $"EmployeeId: {ID}, Name: {Name}";
    }
  }

  public class Manager : Employee
  {
    public Manager(string ID, string Name, decimal BasicSalary) : base(ID, Name, BasicSalary)
    {
    }

    public override decimal calHoursBonus(decimal hours)
    {
      return Math.Round(((BasicSalary / 30) / 8) * hours * 2, 2);
    }
  }

  public class RegularEmp : Employee
  {
    public RegularEmp(string ID, string Name, decimal BasicSalary) : base(ID, Name, BasicSalary)
    {
    }

    public override decimal calHoursBonus(decimal hours)
    {
      return Math.Round(((BasicSalary / 30) / 8) * hours, 2);
    }
  }
}