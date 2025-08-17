using NominaBasica.Domain;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Nómina (versión simple / principiante)\n");

// Lista polimórfica: todos son Employee
var empleados = new List<Employee>
{
    new SalariedEmployee("E-001", "Gerard Ubiera", 12000m),                 
    new HourlyEmployee("E-002", "Petrachevsky Ubiera", 250m, 45m),               
    new CommissionEmployee("E-003", "Delfina Castillo", 80000m, 0.08m),       
    new SalariedCommissionEmployee("E-004", "Montserrat Ubiera", 10000m, 50000m, 0.10m, true) 
};

decimal total = 0m;
foreach (var e in empleados)
{
    var pago = e.CalculateWeeklyPay();
    Console.WriteLine($"{e} => RD$ {pago:N2}");
    total += pago;
}

Console.WriteLine("--------------------------------------");
Console.WriteLine($"TOTAL A PAGAR: RD$ {total:N2}");
