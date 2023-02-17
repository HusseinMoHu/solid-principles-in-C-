namespace OpenClosedPrinciple
{
  public enum EmployeesTypes
  {
    Manager,
    Regular,
  };

  public abstract class Employee
  {
    public string? ID { get; set; }
    public string? Name { get; set; }
    public decimal BasicSalary { get; set; }

    public abstract decimal calHoursBonus(decimal hours);

    public override string ToString()
    {
      return $"EmployeeId: {ID}, Name: {Name}";
    }
  }

  public class Manager : Employee
  {
    public override decimal calHoursBonus(decimal hours)
    {
      return ((BasicSalary / 30) / 8) * hours * 2;
    }
  }
}