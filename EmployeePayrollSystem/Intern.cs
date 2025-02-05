public class Intern : BaseEmployee
{
    public Intern(string name, int id, decimal basicPay, decimal allowances)
        : base(name, id, "Intern", basicPay, allowances)
    {
    }

    public override decimal CalculateSalary()
    {
        decimal deductions = 0.05m * BasicPay; // Interns might have lesser deductions
        return BasicPay + Allowances - deductions;
    }
}
