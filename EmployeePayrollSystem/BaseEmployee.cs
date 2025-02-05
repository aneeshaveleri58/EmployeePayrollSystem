using System;

public class BaseEmployee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Role { get; set; }
    public decimal BasicPay { get; set; }
    public decimal Allowances { get; set; }

    public BaseEmployee(string name, int id, string role, decimal basicPay, decimal allowances)
    {
        Name = name;
        ID = id;
        Role = role;
        BasicPay = basicPay;
        Allowances = allowances;
    }

    public virtual decimal CalculateSalary()
    {
        decimal deductions = 0.1m * BasicPay; // Example deduction as 10% of basic pay
        return BasicPay + Allowances - deductions;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Role: {Role}, Basic Pay: {BasicPay}, Allowances: {Allowances}");
    }
}
