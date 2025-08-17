namespace NominaBasica.Domain;

public sealed class CommissionEmployee : Employee
{
    public decimal Sales { get; set; }
    public decimal CommissionRate { get; set; } 

    public CommissionEmployee(string id, string name, decimal sales, decimal commissionRate)
        : base(id, name)
    {
        Sales = sales;
        CommissionRate = commissionRate;
    }

    public override decimal CalculateWeeklyPay() => Sales * CommissionRate;
}
