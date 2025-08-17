namespace NominaBasica.Domain;

public abstract class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public virtual string Role => GetType().Name;

    protected Employee(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract decimal CalculateWeeklyPay();

    public override string ToString() => $"{Role} - {Name} ({Id})";
}
