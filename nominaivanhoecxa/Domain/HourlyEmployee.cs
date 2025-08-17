namespace NominaBasica.Domain;

public sealed class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public decimal HoursWorked { get; set; }

    public HourlyEmployee(string id, string name, decimal hourlyRate, decimal hoursWorked)
        : base(id, name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateWeeklyPay()
    {
        const decimal threshold = 40m;
        const decimal extra = 1.5m;

        if (HoursWorked <= threshold)
            return HourlyRate * HoursWorked;

        var regular = HourlyRate * threshold;
        var overtime = (HoursWorked - threshold) * HourlyRate * extra;
        return regular + overtime;
    }
}
