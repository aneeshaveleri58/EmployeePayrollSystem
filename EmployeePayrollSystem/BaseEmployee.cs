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
        // Print the table headers
        Console.WriteLine("+------------+----------------------+------------+-------------+-----------+");
        Console.WriteLine("| EmployeeID | Name                 | Role       | Basic Pay  | Allowances |");
        Console.WriteLine("+------------+----------------------+------------+-------------+-----------+");

        // Print the employee details in a row format
        Console.WriteLine("| {0,-10} | {1,-20} | {2,-10} | {3,11:C} | {4,10:C} |", ID, Name, Role, BasicPay, Allowances);

        // Print the separator line
        Console.WriteLine("+------------+----------------------+------------+-------------+-----------+");

        // If you have additional role-specific information (like bonus for Manager)
        if (this is Manager manager)
        {
            Console.WriteLine("| Bonus      | {0,11:C} |", manager.Bonus);
            Console.WriteLine("+------------+----------------------+------------+-------------+-----------+");
        }
        else if (this is Developer developer)
        {
            Console.WriteLine("| Project All | {0,11:C} |", developer.ProjectAllowance);
            Console.WriteLine("+------------+----------------------+------------+-------------+-----------+");
        }
    }

}
