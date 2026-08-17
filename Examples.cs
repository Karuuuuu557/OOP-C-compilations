using System;

class Program
{
    static void Main(string[] args)
    {
        //Looping examples
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

        //Array samples

        // Program 1: swapping two numbers
        Console.WriteLine("Swapping Two Numbers");      
        Console.WriteLine("Enter Number 1");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Number 2");
        int num2 = int.Parse(Console.ReadLine());

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("Number 1: " + num1);
        Console.WriteLine("Number 2: " + num2);

        Console.WriteLine();

        // Program 2: finding the greatest number
        Console.WriteLine("Finding the Greatest Number");

        Console.Write("Enter Number 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 3: ");
        int c = int.Parse(Console.ReadLine());

        int greatest = Math.Max(a, Math.Max(b, c));
        int smallest = Math.Min(a, Math.Min(b, c));

        Console.WriteLine($"The greatest number is: " + greatest );
        Console.WriteLine($"The smallest number is: " + smallest );

        //program 3: check the nearest value of 20 of two given numbers
        Console.WriteLine("Finding the Nearest Value to 20");

        Console.Write("Enter Number 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int n2 = int.Parse(Console.ReadLine());

        int diff1 = Math.Abs(n1 - 20);
        int diff2 = Math.Abs(n2 - 20);

        if (diff1 < diff2)
        {
            Console.WriteLine("Number 1 ("+ n1 +") is closer to 20");
        }
        else if (diff2 < diff1)
        {
            Console.WriteLine("Number 2 ("+ n2 +") is closer to 20");
        }
        else
        {
            Console.WriteLine("Both numbers are equally close to 20");
        }

    // Program 4: Check if two numbers have the same parity (both even or both odd)

       Console.WriteLine("Checking Parity of Two Numbers");

       Console.Write("Enter Number 1: ");
       int p1 = int.Parse(Console.ReadLine());

       Console.Write("Enter Number 2: ");
       int p2 = int.Parse(Console.ReadLine());

       string parity1 = (p1 % 2 == 0) ? "even" : "odd";
       string parity2 = (p2 % 2 == 0) ? "even" : "odd";

       Console.WriteLine($"Number 1 is {parity1}");
       Console.WriteLine($"Number 2 is {parity2}");

       if (parity1 == parity2)
       {
           Console.WriteLine($"Both numbers are {parity1}");
       }
       else
       {
           Console.WriteLine("Numbers have different parity");
       }
    // Program 5: Determine whether a given number is positive, negative, or zero

         Console.WriteLine("Checking if a Number is Positive, Negative, or Zero");

         Console.Write("Enter a Number: ");
         int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is Negative");
        }
        else
        {
            Console.WriteLine("The number is Zero");
        }
    // Program 6: Check whether a year is a leap year or not
        Console.WriteLine("Check if year inputted is a leap year or not");

        Console.Write("Enter a Year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap year.");
        }
    // Program 7: Check if a number falls in the range [10, 50] (inclusive) or outside it
    
        Console.WriteLine("Check if a number falls in the range [10, 50] (inclusive) or outside it");

        Console.Write("Enter a Number: ");
        int rangeNum = int.Parse(Console.ReadLine());

        if (rangeNum >= 10 && rangeNum <= 50)
        {
            Console.WriteLine($"{rangeNum} is within the range [10, 50]");
        }
        else
        {
            Console.WriteLine($"{rangeNum} is outside the range [10, 50]");
        }
     // Program 8: Find the second largest number among three given numbers 
        Console.WriteLine("Finding the second Largest number is a set of three numbers");

        Console.Write("Enter Number 1: ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Enter Number 2: ");
        int numB = int.Parse(Console.ReadLine());
        Console.Write("Enter Number 3: ");
        int numC = int.Parse(Console.ReadLine());

        int largest = Math.Max(numA, Math.Max(numB, numC));
        int smallest = Math.Min(numA, Math.Min(numB, numC));

        int secondLargest = (numA + numB + numC) - largest - smallest;//get the sum of the three numbers and subtract the largest and smallest to get the remaining which is the second largest number

        Console.WriteLine($"The second largest number is: {secondLargest}");

       // Program 9: Check if a number is positive, negative, or zero (using the ternary operator)
         Console.WriteLine("Checking if a Number is Positive, Negative, or Zero (using the ternary operator)");

         Console.Write("Enter a Number: ");
         int ternaryNum = int.Parse(Console.ReadLine());

         string result = (ternaryNum > 0) ? "Postive" : (ternaryNum < 0) ? "Negative" : "Zero";
         Console.WriteLine($"The number {ternaryNum} is {result}");

    // Program 9: Check if a number is positive, negative, or zero (using the ternary operator)
       Console.WriteLine("Enter a Number");
       int Num = int.Parse(Console.ReadLine());

       string result = (Num > 0) ? "Positive" : (Num < 0) ? "Negative" : "zero";
            Console.WriteLine($"The number {Num} is: {result}");

    }
       
       
       

       // Program 10: Check whether a given number is odd or even using the ternary operator
       // Program 11: Calculate the absolute difference between two numbers and check if it's less than a threshold
       // Program 11: Calculate the absolute difference between two numbers and check if it's less than a threshold
       // Program 12: Check if a character is uppercase or lowercase (or neither)
       // Program 13: Determine whether two numbers are both positive, both negative, or have mixed signs
       // Program 14: Check whether a number is between two given values (exclusive or inclusive range)
       // Program 15: Check whether a number is divisible by another (and print the quotient)
       // Program 16: Find the largest number among three without using if-else (using Math.Max)
       // Program 17: Check whether a given character is alphanumeric (letter or digit)
       // Program 18: Find the nearest value to zero from two given numbers
       // Program 19: Check whether two numbers are coprime (their GCD is 1) using Euclid's algorithm
       // Program 20: Find the sum, difference, product, and quotient of two numbers (with zero-division guard)

       //Comprehensive C# Exercises

// these are looping examples
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
