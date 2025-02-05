using System;
using System.Collections.Generic;

public class PayrollSystem
{
    private List<BaseEmployee> employees = new List<BaseEmployee>();

    public void AddEmployee()
    {
        Console.Write("Enter employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Enter employee role (Manager, Developer, Intern): ");
        string role = Console.ReadLine();

        Console.Write("Enter basic pay: ");
        decimal basicPay = decimal.Parse(Console.ReadLine());

        Console.Write("Enter allowances: ");
        decimal allowances = decimal.Parse(Console.ReadLine());

        BaseEmployee employee = null;

        if (role.ToLower() == "manager")
        {
            Console.Write("Enter bonus: ");
            decimal bonus = decimal.Parse(Console.ReadLine());
            employee = new Manager(name, id, basicPay, allowances, bonus);
        }
        else if (role.ToLower() == "developer")
        {
            Console.Write("Enter project allowance: ");
            decimal projectAllowance = decimal.Parse(Console.ReadLine());
            employee = new Developer(name, id, basicPay, allowances, projectAllowance);
        }
        else if (role.ToLower() == "intern")
        {
            employee = new Intern(name, id, basicPay, allowances);
        }

        employees.Add(employee);
        Console.WriteLine("Employee added successfully.");
    }

    public void DisplayAllEmployees()
    {
        Console.WriteLine("Employee Details:");
        foreach (var employee in employees)
        {
            employee.DisplayDetails();
            Console.WriteLine($"Salary: {employee.CalculateSalary():C}");
            Console.WriteLine("-----------------------------");
        }
    }

    public void DisplayEmployeeSalary()
    {
        Console.Write("Enter employee ID: ");
        int id = int.Parse(Console.ReadLine());

        var employee = employees.Find(e => e.ID == id);
        if (employee != null)
        {
            Console.WriteLine($"Salary for {employee.Name}: {employee.CalculateSalary():C}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    public void DisplayTotalPayroll()
    {
        decimal totalPayroll = 0;
        foreach (var employee in employees)
        {
            totalPayroll += employee.CalculateSalary();
        }
        Console.WriteLine($"Total Payroll: {totalPayroll:C}");
    }
}
