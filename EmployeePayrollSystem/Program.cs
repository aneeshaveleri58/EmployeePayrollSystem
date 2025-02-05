
using System;

class Program
{
    static void Main(string[] args)
    {
        PayrollSystem payrollSystem = new PayrollSystem();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Employee Payroll System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All Employee Details");
            Console.WriteLine("3. Display Employee Salary");
            Console.WriteLine("4. Display Total Payroll");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    payrollSystem.AddEmployee();
                    break;
                case 2:
                    payrollSystem.DisplayAllEmployees();
                    break;
                case 3:
                    payrollSystem.DisplayEmployeeSalary();
                    break;
                case 4:
                    payrollSystem.DisplayTotalPayroll();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
