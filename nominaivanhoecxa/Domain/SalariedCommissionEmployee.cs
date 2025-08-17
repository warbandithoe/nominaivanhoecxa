namespace NominaBasica.Domain;

public sealed class SalariedCommissionEmployee : Employee
{
    public decimal BaseSalary { get; set; }
    public decimal Sales { get; set; }
    public decimal CommissionRate { get; set; } 
    public bool Apply10PctBonus { get; set; } = true; 

    public SalariedCommissionEmployee(
        string id, string name,
        decimal baseSalary, decimal sales, decimal commissionRate,
        bool apply10PctBonus = true)
        : base(id, name)
    {
        BaseSalary = baseSalary;
        Sales = sales;
        CommissionRate = commissionRate;
        Apply10PctBonus = apply10PctBonus;
    }

    public override decimal CalculateWeeklyPay()
    {
        var commission = Sales * CommissionRate;
        var bonus = Apply10PctBonus ? BaseSalary * 0.10m : 0m;
        return BaseSalary + bonus + commission;
    }
}
