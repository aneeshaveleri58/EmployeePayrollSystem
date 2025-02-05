using System;

public class Developer : BaseEmployee
{
    public decimal ProjectAllowance { get; set; }

    public Developer(string name, int id, decimal basicPay, decimal allowances, decimal projectAllowance)
        : base(name, id, "Developer", basicPay, allowances)
    {
        ProjectAllowance = projectAllowance;
    }

    public override decimal CalculateSalary()
    {
        decimal deductions = 0.1m * BasicPay;
        return BasicPay + Allowances + ProjectAllowance - deductions;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Project Allowance: {ProjectAllowance}");
    }
}
