using System;

public class Manager : BaseEmployee
{
    public decimal Bonus { get; set; }

    public Manager(string name, int id, decimal basicPay, decimal allowances, decimal bonus)
        : base(name, id, "Manager", basicPay, allowances)
    {
        Bonus = bonus;
    }

    public override decimal CalculateSalary()
    {
        decimal deductions = 0.1m * BasicPay;
        return BasicPay + Allowances + Bonus - deductions;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Bonus: {Bonus}");
    }
}
