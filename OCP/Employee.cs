namespace OpenClosedPrinciple
{
  public enum EmployeesTypes
  {
    Manager,
    Regular,
  };

  public class Employee
  {
    public string? ID { get; set; }
    public string? Name { get; set; }
    public decimal BasicSalary { get; set; }
    public EmployeesTypes EmployeeType { get; set; }

    public decimal calHoursBonus(decimal hours)
    {
      return ((BasicSalary / 30) / 8) * hours;
    }

    public override string ToString()
    {
      return $"EmployeeId: {ID}, Name: {Name}";
    }
  }
}