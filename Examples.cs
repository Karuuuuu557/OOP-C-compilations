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
        GetArray();
        displayElements();
        accessFirstLast();
        addElememt();
        modifArray();
        remArray();
        calcArray();
        revArray();

        //General practice codes
        swapNum();
        greatestNum();
        nearestValueTo20();
        parityCheck();
        positiveNegativeZero();
        leapYearCheck();
        rangeCheck();
        secondLargestNumber();
        ternaryNumberCheck();

        // Program 1: swapping two numbers
        static void swapNum()
        {
            Console.WriteLine("\nSwapping Two Numbers");
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
        }

        static void greatestNum()
        {
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

            Console.WriteLine("The greatest number is: " + greatest);
            Console.WriteLine("The smallest number is: " + smallest);
            Console.WriteLine();
        }

        static void nearestValueTo20()
        {
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
                Console.WriteLine("Number 1 (" + n1 + ") is closer to 20");
            }
            else if (diff2 < diff1)
            {
                Console.WriteLine("Number 2 (" + n2 + ") is closer to 20");
            }
            else
            {
                Console.WriteLine("Both numbers are equally close to 20");
            }
            Console.WriteLine();
        }

        static void parityCheck()
        {
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
            Console.WriteLine();
        }

        static void positiveNegativeZero()
        {
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
            Console.WriteLine();
        }

        static void leapYearCheck()
        {
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
            Console.WriteLine();
        }

        static void rangeCheck()
        {
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
            Console.WriteLine();
        }

        static void secondLargestNumber()
        {
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

            int secondLargest = (numA + numB + numC) - largest - smallest;

            Console.WriteLine($"The second largest number is: {secondLargest}");
            Console.WriteLine();
        }

        static void ternaryNumberCheck()
        {
            // Program 9: Check if a number is positive, negative, or zero (using the ternary operator)
            Console.WriteLine("Checking if a Number is Positive, Negative, or Zero (using the ternary operator)");

            Console.Write("Enter a Number: ");
            int ternaryNum = int.Parse(Console.ReadLine());

            string result = (ternaryNum > 0) ? "Positive" : (ternaryNum < 0) ? "Negative" : "Zero";
            Console.WriteLine($"The number {ternaryNum} is {result}");
            Console.WriteLine();
        }

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
    /*

public static void Main(string[] args)
{
    // Step 1: User Input for Array Size and Elements
    Console.WriteLine("Enter the size of the array:");
    int size = int.Parse(Console.ReadLine());

    int[] myArray = new int[size];

    // Input the array elements from the user
    Console.WriteLine("Enter the elements of the array:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Element {i + 1}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }

    // Print the original array
    Console.WriteLine("\nOriginal Array:");
    PrintArray(myArray);
}

INSTRUCTIONS:
1.	Display the Elements
2.	Access Array Elements (First and Last)
3.	Add an Element to the Array
4.	Modify an Array Element 
5.	Remove an Element from the Array
6.	Calculate and Print the Sum of Array Elements
7.	Reverse the Array

*/
    static int[] myArray;

    static void GetArray()
    {
        Console.WriteLine("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        myArray = new int[size];

        Console.WriteLine("Enter the elements of the array: ");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }
    }

//1.	Display the Elements
    static void displayElements()
    {
        Console.WriteLine("\nProgram 1: Display the Elements");
        Console.WriteLine("Original Array");
        Console.WriteLine(string.Join(", ", myArray)); //gets the arrays content and prints in one single line
        Console.WriteLine();
    }

//2.   Access the first and last array
    static void accessFirstLast()
    {
        Console.WriteLine("\nProgram 2: Access First and Last Element");
        Console.WriteLine($"The first element is: {myArray[0]}. The last element is {myArray[myArray.Length - 1]}");
        Console.WriteLine();
    }

//3.   Add an element to the array
    static void addElememt()
    {
        Console.WriteLine("\nProgram 3: Add an Element to the Array");
        Console.WriteLine("Enter a number to add to the array: ");
        int newElement = int.Parse(Console.ReadLine());

        Array.Resize(ref myArray, myArray.Length + 1);
        myArray[myArray.Length - 1] = newElement;
        Console.WriteLine("Array after adding element: " + string.Join(", ", myArray));
        Console.WriteLine();
    }

//4. modify an element to the array
    static void modifArray()
    {
        Console.WriteLine("\nProgram 4: Modify an Array Element");
        Console.WriteLine(string.Join(", ", myArray)); 
        Console.WriteLine("Enter the index of the element you want to modify (1-based): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Enter the new element:");
        int newValue = int.Parse(Console.ReadLine());

        if (index >= 0 && index < myArray.Length)
        {
            myArray[index] = newValue;
            Console.WriteLine("Element modified successfully.");
            Console.WriteLine("Updated array: " +  string.Join(", ", myArray));
        }
        else
            {
                Console.WriteLine("Invalid index!");
            }
        Console.WriteLine();
    }
//5. Remove an element from the array
    static void remArray()
    {
        Console.WriteLine("\nProgram 5: Remove an Element from the Array");
        Console.WriteLine(string.Join(", ", myArray));
        Console.WriteLine("Enter the index of the element you want to remove (1-based): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < myArray.Length)
        {
            int[] tempArray = new int[myArray.Length - 1];
            
            for (int i = 0, j = 0; i < myArray.Length; i++)
            {
                if (i != index)
                {
                    tempArray[j] = myArray[i];
                    j++;
                }
            }
            
            myArray = tempArray;
            Console.WriteLine("Element removed successfully.");
            Console.WriteLine("Updated array: " + string.Join(", ", myArray));
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
        Console.WriteLine();
    }

//6. Calculate and Print the Sum of Array Elements
    static void calcArray()
    {
        Console.WriteLine("\nProgram 6: Calculate and Print the Sum");
        Console.WriteLine(string.Join(", ", myArray));
        
        int sum = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            sum += myArray[i];
        }
        
        Console.WriteLine($"Sum of all elements: {sum}");
        Console.WriteLine();
    }
//7.  Reverse the array
    static void revArray()
    {
        Console.WriteLine("\nProgram 7: Reverse the Array");
        Console.WriteLine("Original array: " + string.Join(", ", myArray));
        
        Array.Reverse(myArray);
        
        Console.WriteLine("Reversed array: " + string.Join(", ", myArray));
        Console.WriteLine();
    }
}