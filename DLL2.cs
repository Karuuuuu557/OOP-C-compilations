using System;
using SalaryLibrary;

namespace SalaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = null;
            bool running = true;

            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        emp = ReadEmployee();
                        Console.WriteLine("Employee information saved.");
                        break;
                    case "2":
                        if (HasEmployee(emp)) DisplayEmployee(emp);
                        break;
                    case "3":
                        if (HasEmployee(emp))
                            Console.WriteLine("Gross Salary: " + emp.CalculateGrossSalary().ToString("N2"));
                        break;
                    case "4":
                        if (HasEmployee(emp))
                        {
                            Console.WriteLine("Tax Rate: " + (emp.GetTaxRate() * 100).ToString("0.##") + "%");
                            Console.WriteLine("Tax: " + emp.CalculateTax().ToString("N2"));
                        }
                        break;
                    case "5":
                        if (HasEmployee(emp))
                            Console.WriteLine("Net Salary: " + emp.CalculateNetSalary().ToString("N2"));
                        break;
                    case "6":
                        if (HasEmployee(emp))
                            Console.WriteLine("Salary Grade: " + emp.GetSalaryGrade());
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-7.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.Write("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("        EMPLOYEE SALARY SYSTEM");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Enter Employee Information");
            Console.WriteLine("2. Display Employee Information");
            Console.WriteLine("3. Calculate Gross Salary");
            Console.WriteLine("4. Calculate Tax");
            Console.WriteLine("5. Calculate Net Salary");
            Console.WriteLine("6. Display Salary Grade");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
        }

        static Employee ReadEmployee()
        {
            Employee e = new Employee();

            Console.Write("Employee ID: ");
            e.EmployeeID = Console.ReadLine();

            Console.Write("Employee Name: ");
            e.EmployeeName = Console.ReadLine();

            e.BasicSalary = ReadAmount("Basic Salary: ");
            e.Allowance = ReadAmount("Allowance: ");
            e.Deduction = ReadAmount("Deduction: ");

            return e;
        }

        static double ReadAmount(string prompt)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value) || value < 0)
            {
                Console.Write("Invalid amount. " + prompt);
            }
            return value;
        }

        static bool HasEmployee(Employee e)
        {
            if (e == null)
            {
                Console.WriteLine("No employee yet. Please choose option 1 first.");
                return false;
            }
            return true;
        }

        static void DisplayEmployee(Employee e)
        {
            Console.WriteLine("Employee ID: " + e.EmployeeID);
            Console.WriteLine("Employee Name: " + e.EmployeeName);
            Console.WriteLine("Basic Salary: " + e.BasicSalary.ToString("N2"));
            Console.WriteLine("Allowance: " + e.Allowance.ToString("N2"));
            Console.WriteLine("Deduction: " + e.Deduction.ToString("N2"));
        }
    }
}