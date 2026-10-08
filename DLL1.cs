namespace SalaryLibrary
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Deduction { get; set; }

        public double CalculateGrossSalary()
        {
            return BasicSalary + Allowance;
        }

        public double GetTaxRate()
        {
            double gross = CalculateGrossSalary();

            if (gross <= 20000) return 0.05;
            if (gross <= 40000) return 0.10;
            if (gross <= 60000) return 0.15;
            return 0.20;
        }

        public double CalculateTax()
        {
            return CalculateGrossSalary() * GetTaxRate();
        }

        // Net Salary = Gross Salary - Tax - Deduction
        public double CalculateNetSalary()
        {
            return CalculateGrossSalary() - CalculateTax() - Deduction;
        }

        public string GetSalaryGrade()
        {
            double gross = CalculateGrossSalary();

            if (gross <= 15000) return "Grade 1";
            if (gross <= 25000) return "Grade 2";
            if (gross <= 40000) return "Grade 3";
            return "Grade 4";
        }
    }
}
