//Comprehensive C# Exercises
using System;

class Exercises
{
    static void Main(string[] args)
    {
        DisplayEvenNumbers();
        SumOfNumbers();
        MultiplicationTable();
        FactorialCalculator();
        PasswordVerification();
        NumberGuessingGame();
        SimpleMenuSystem();
        RightTrianglePattern();
        NumberPattern();
        ATMTransactionSimulator();
    }

    // 1. Display Even Numbers
    static void DisplayEvenNumbers()
    {
        Console.WriteLine("\nProgram 1: Display Even Numbers");
        Console.WriteLine("Enter limit: ");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEven numbers from 1 to " + limit + ":");
        for (int i = 2; i <= limit; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");
    }

    // 2. Sum of Numbers
    static void SumOfNumbers()
    {
        Console.WriteLine("\nProgram 2: Sum of Numbers");
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine();
    }

    // 3. Multiplication Table
    static void MultiplicationTable()
    {
        Console.WriteLine("\nProgram 3: Multiplication Table");
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
        Console.WriteLine();
    }

    // 4. Factorial Calculator
    static void FactorialCalculator()
    {
        Console.WriteLine("\nProgram 4: Factorial Calculator");
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(number + "! = " + factorial);
        Console.WriteLine();
    }

    // 5. Password Verification
    static void PasswordVerification()
    {
        Console.WriteLine("\nProgram 5: Password Verification");
        Console.WriteLine("Set the correct password: ");
        string correctPassword = Console.ReadLine();
        string password = "";

        while (password != correctPassword)
        {
            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            if (password != correctPassword)
            {
                Console.WriteLine("Incorrect password.\n");
            }
            else
            {
                Console.WriteLine("Access Granted!");
            }
        }
        Console.WriteLine();
    }

    // 6. Number Guessing Game
    static void NumberGuessingGame()
    {
        Console.WriteLine("\nProgram 6: Number Guessing Game");
        Console.WriteLine("Enter minimum number: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter maximum number: ");
        int max = int.Parse(Console.ReadLine());
        
        Random random = new Random();
        int secretNumber = random.Next(min, max + 1);
        int guess = -1;

        while (guess != secretNumber)
        {
            Console.WriteLine("Guess the number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > secretNumber)
            {
                Console.WriteLine("Too high!\n");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low!\n");
            }
            else
            {
                Console.WriteLine("Correct! You guessed the number.");
            }
        }
        Console.WriteLine();
    }

    // 7. Simple Menu System
    static void SimpleMenuSystem()
    {
        Console.WriteLine("\nProgram 7: Simple Menu System");
        int choice = 0;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Display Date");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello! Welcome to the menu system.\n");
                    break;
                case 2:
                    Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                    break;
                case 3:
                    Console.WriteLine("Exiting...\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.\n");
                    break;
            }
        } while (choice != 3);
        Console.WriteLine();
    }

    // 8. Right Triangle Pattern
    static void RightTrianglePattern()
    {
        Console.WriteLine("\nProgram 8: Right Triangle Pattern");
        Console.WriteLine("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // 9. Number Pattern
    static void NumberPattern()
    {
        Console.WriteLine("\nProgram 9: Number Pattern");
        Console.WriteLine("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // 10. ATM Transaction Simulator
    static void ATMTransactionSimulator()
    {
        Console.WriteLine("\nProgram 10: ATM Transaction Simulator");
        Console.WriteLine("Enter initial balance: ");
        double balance = double.Parse(Console.ReadLine());
        int choice = 0;

        do
        {
            Console.WriteLine("\n===== ATM MENU =====");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your current balance is: Pesos " + balance + "\n");
                    break;
                case 2:
                    Console.WriteLine("Enter amount to deposit: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine("Successfully deposited Pesos " + depositAmount);
                    Console.WriteLine("Your new balance is: Pesos " + balance + "\n");
                    break;
                case 3:
                    Console.WriteLine("Enter amount to withdraw: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    
                    if (withdrawAmount > balance)
                    {
                        Console.WriteLine("Insufficient balance! Your balance is only Pesos " + balance + "\n");
                    }
                    else
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine("Successfully withdrew Pesos " + withdrawAmount);
                        Console.WriteLine("Your new balance is: Pesos " + balance + "\n");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thank you for using our ATM. Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.\n");
                    break;
            }
        } while (choice != 4);
        Console.WriteLine();
    }
}
