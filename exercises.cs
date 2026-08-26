using System;

namespace OOP_MachineProblems
{
    // ==========================================
    // MACHINE PROBLEM 1 - STUDENT INFORMATION
    // ==========================================

    public class Student
    {
        public string name;
        public string studentId;
        public string course;
        public int age;

        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }

        public void introduce()
        {
            Console.WriteLine("Hello! My name is " + name + ".");
            Console.WriteLine();
        }
    }


    // ==========================================
    // MACHINE PROBLEM 2 - PRODUCT INFORMATION
    // ==========================================

    public class Product
    {
        public string productName;
        public string productCode;
        public double price;
        public int quantity;

        public void displayProduct()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Product Code: " + productCode);
            Console.WriteLine("Price: " + price.ToString("F2"));
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total Value: " + calculateTotal().ToString("F2"));
            Console.WriteLine();
        }

        public double calculateTotal()
        {
            return price * quantity;
        }
    }


    // ==========================================
    // MACHINE PROBLEM 4 - RECTANGLE CALCULATOR
    // ==========================================

    public class Rectangle
    {
        public double length;
        public double width;

        public double calculateArea()
        {
            return length * width;
        }

        public double calculatePerimeter()
        {
            return 2 * (length + width);
        }

        public void displayResult()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + calculateArea());
            Console.WriteLine("Perimeter: " + calculatePerimeter());
            Console.WriteLine();
        }
    }


    // ==========================================
    // BANK ACCOUNT
    // ==========================================

    public class BankAccount
    {
        public String accountNumber;
        public String accountName;
        public double balance;

        // Default constructor
        public BankAccount()
        {
            accountNumber = "0000";
            accountName = "Unknown";
            balance = 0.0;

            Console.WriteLine("");
        }

        // Parameterized constructor
        public BankAccount(String accNum, String accName, double bal)
        {
            accountNumber = accNum;
            accountName = accName;
            balance = bal;

            Console.WriteLine("");
        }

        // Destructor
        ~BankAccount()
        {
            Console.WriteLine(
                "BankAccount object (Account Number: "
                + accountNumber
                + ") is being getting trashed."
            );
        }

        public void displayAccount()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Initial Balance: " + balance.ToString("F2"));
            Console.WriteLine("");
        }

        public void deposit(double amount)
        {
            balance = balance + amount;

            Console.WriteLine("Deposit: " + amount.ToString("F2"));
        }

        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Withdraw failed: Insufficient balance.");
            }
            else
            {
                balance = balance - amount;

                Console.WriteLine("Withdraw: " + amount.ToString("F2"));
            }
        }

        public double checkBalance()
        {
            return balance;
        }
    }


    // ==========================================
    // MAIN PROGRAM
    // ==========================================

    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // MACHINE PROBLEM 1 - STUDENT INFORMATION
            // ==========================================

            Student s1 = new Student();
            s1.name = "Juan Dela Cruz";
            s1.studentId = "2026-001";
            s1.course = "BSIT";
            s1.age = 20;

            Student s2 = new Student();
            s2.name = "Maria Santos";
            s2.studentId = "2026-002";
            s2.course = "BSIT";
            s2.age = 19;

            Student s3 = new Student();
            s3.name = "Pedro Reyes";
            s3.studentId = "2026-003";
            s3.course = "BSIT";
            s3.age = 21;

            Console.WriteLine("==========================================");
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("STUDENT 1");
            s1.displayInfo();
            s1.introduce();

            Console.WriteLine("STUDENT 2");
            s2.displayInfo();
            s2.introduce();

            Console.WriteLine("STUDENT 3");
            s3.displayInfo();
            s3.introduce();


            // ==========================================
            // MACHINE PROBLEM 2 - PRODUCT INFORMATION
            // ==========================================

            Product p1 = new Product();
            p1.productName = "Laptop";
            p1.productCode = "P001";
            p1.price = 35000.00;
            p1.quantity = 2;

            Product p2 = new Product();
            p2.productName = "Mouse";
            p2.productCode = "P002";
            p2.price = 1500.00;
            p2.quantity = 3;

            Product p3 = new Product();
            p3.productName = "Keyboard";
            p3.productCode = "P003";
            p3.price = 2500.00;
            p3.quantity = 2;

            Console.WriteLine("==========================================");
            Console.WriteLine("PRODUCT INFORMATION");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            p1.displayProduct();
            p2.displayProduct();
            p3.displayProduct();


            // ==========================================
            // MACHINE PROBLEM 4 - RECTANGLE CALCULATOR
            // ==========================================

            Rectangle r1 = new Rectangle();
            r1.length = 10;
            r1.width = 5;

            Rectangle r2 = new Rectangle();
            r2.length = 15;
            r2.width = 8;

            Rectangle r3 = new Rectangle();
            r3.length = 20;
            r3.width = 10;

            Console.WriteLine("==========================================");
            Console.WriteLine("RECTANGLE CALCULATOR");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("RECTANGLE 1");
            r1.displayResult();

            Console.WriteLine("RECTANGLE 2");
            r2.displayResult();

            Console.WriteLine("RECTANGLE 3");
            r3.displayResult();


            // ==========================================
            // BANK ACCOUNT
            // ==========================================

            BankAccount account1 =
                new BankAccount("1001", "Juan Dela Cruz", 10000.00);

            BankAccount account2 =
                new BankAccount("1002", "Maria Santos", 15000.00);

            Console.WriteLine("==========================================");
            Console.WriteLine("BANK ACCOUNT");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            account1.displayAccount();

            account1.deposit(5000.00);

            account1.withdraw(999999);

            Console.WriteLine(
                "Updated Balance: "
                + account1.checkBalance().ToString("F2")
            );

            Console.WriteLine();

            account2.displayAccount();

            account2.deposit(3000.00);

            account2.withdraw(1000.00);

            Console.WriteLine(
                "Updated Balance: "
                + account2.checkBalance().ToString("F2")
            );

            Console.WriteLine();
        }
    }
}