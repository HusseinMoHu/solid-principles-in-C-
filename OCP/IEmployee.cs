namespace OCP
{

  // Apply the OCP principle using: implement interface
  public interface IEmployee
  {
    string? ID { get; set; }
    string? Name { get; set; }
    decimal BasicSalary { get; set; }
    decimal calHoursBonus(decimal hours);
  }

  public class ManagerEmployee : IEmployee
  {
    public string? ID { get; set; }
    public string? Name { get; set; }
    public decimal BasicSalary { get; set; }

    public decimal calHoursBonus(decimal hours)
    {
      return Math.Round(((BasicSalary / 30) / 8) * hours * 2, 2);
    }

    public override string ToString()
    {
      return $"EmployeeId: {ID}, Name: {Name}";
    }
  }

  public class RegularEmployee : IEmployee
  {
    public string? ID { get; set; }
    public string? Name { get; set; }
    public decimal BasicSalary { get; set; }

    public decimal calHoursBonus(decimal hours)
    {
      return Math.Round(((BasicSalary / 30) / 8) * hours, 2);
    }

    public override string ToString()
    {
      return $"EmployeeId: {ID}, Name: {Name}";
    }
  }
}