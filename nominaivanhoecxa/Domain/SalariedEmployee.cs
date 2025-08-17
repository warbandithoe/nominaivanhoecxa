namespace NominaBasica.Domain;

public sealed class SalariedEmployee : Employee
{
    public decimal WeeklySalary { get; set; }

    public SalariedEmployee(string id, string name, decimal weeklySalary)
        : base(id, name)
    {
        WeeklySalary = weeklySalary;
    }

    public override decimal CalculateWeeklyPay() => WeeklySalary;
}
