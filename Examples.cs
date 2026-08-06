using System;

class Program
{
    static void Main(string[] args)
    {
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
            Consoe.WriteLine("The number is Zero");
        }
    // Program 6: Check whether a year is a leap year or not
        Console.WriteLine("Check if year inputted is a leap year or not");

        Console.Write("Enter a Year: ");
        int year = int.Parse(Console.Readline());

        if ((year & 4 == 0 && year &&  100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{year} is a leap year.");
        }
        else
        {
            Console.WriteLine("{year} is not a Leap year.");
        }
    }
       // Program 7: Check if a number falls in the range [10, 50] (inclusive) or outside it
       // Program 8: Find the second largest number among three given numbers
       // Program 9: Check if a number is positive, negative, or zero (using the ternary operator)
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
       
}
