using System;

class Program
{
    // 1. User-defined function
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome Friends!");
        Console.WriteLine("Have a nice day!");
        Console.WriteLine();
    }


    // 2. User-defined function with parameters
    static void WelcomeFriend(string name)
    {
        Console.WriteLine("Welcome friend " + name + " !");
        Console.WriteLine("Have a nice day!");
    }

    static void PrintPersonalizedWelcome()
    {
        Console.Write("Please input a name : ");
        string name = Console.ReadLine();

        WelcomeFriend(name);
        Console.WriteLine();
    }


    // 3. Sum of two numbers
    static int SumNumbers(int a, int b)
    {
        return a + b;
    }

    static void CalculateAndDisplaySum()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The sum of two numbers is : " + SumNumbers(a, b));
        Console.WriteLine();
    }


    // 4. Check if a number is prime
    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void CheckAndDisplayPrimeNumber()
    {
        Console.Write("Input a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine(num + " is a prime number");
        else
            Console.WriteLine(num + " is not a prime number");

        Console.WriteLine();
    }


    // 5. Convert lowercase letter to uppercase
    static char ToUpperCase(char letter)
    {
        return char.ToUpper(letter);
    }

    static void ConvertAndDisplayUpperCase()
    {
        Console.Write("Input a Char : ");
        char letter = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Expected output : " + ToUpperCase(letter));
        Console.WriteLine();
    }


    // 6. Find nearest value to 20
    static int Near20(int a, int b)
    {
        if (a == b)
            return 0;

        if (Math.Abs(20 - a) < Math.Abs(20 - b))
            return a;
        else
            return b;
    }

    static void FindAndDisplayNearestTo20()
    {
        Console.Write("Input first integer: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input second integer: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Near20(a, b));
        Console.WriteLine();
    }


    // 7. Count spaces in a string
    static int CountSpaces(string text)
    {
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
                count++;
        }

        return count;
    }

    static void CountAndDisplaySpaces()
    {
        Console.Write("Please input a string : ");
        string text = Console.ReadLine();

        Console.WriteLine(
            "\"" + text + "\" contains " +
            CountSpaces(text) + " spaces"
        );
        Console.WriteLine();
    }


    // 8. Sum of elements in an array
    static int SumArray(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    static void CalculateAndDisplayArraySum()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("element - " + i + " : ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(
            "The sum of the elements of the array is " +
            SumArray(numbers)
        );
        Console.WriteLine();
    }


    // 9. Swap two numbers
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SwapAndDisplayNumbers()
    {
        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Swap(ref a, ref b);

        Console.WriteLine(
            "Now the 1st number is : " + a +
            " , and the 2nd number is : " + b
        );
        Console.WriteLine();
    }


    // 10. Raise a number to a power
    static int Power(int number, int exponent)
    {
        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= number;
        }

        return result;
    }

    static void CalculateAndDisplayPower()
    {
        Console.Write("Input Base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Exponent : ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            "So, the number " + number +
            " ^ (to the power) " + exponent +
            " = " + Power(number, exponent)
        );
        Console.WriteLine();
    }


    // 11. Fibonacci sequence
    static void Fibonacci(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }

    static void DisplayFibonacciSeries()
    {
        Console.Write("Input number of Fibonacci Series : ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write(
            "The Fibonacci series of " + n +
            " numbers is : "
        );

        Fibonacci(n);
    Console.WriteLine();
    Console.WriteLine();
    }


    // 12. Sum of individual digits
    static int SumDigits(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    static void CalculateAndDisplayDigitSum()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            "The sum of the digits of the number " +
            num + " is : " + SumDigits(num)
        );
        Console.WriteLine();
    }


    // MAIN
    static void Main()
    {
        PrintWelcomeMessage();
        PrintPersonalizedWelcome();
        CalculateAndDisplaySum();
        CheckAndDisplayPrimeNumber();
        ConvertAndDisplayUpperCase();
        FindAndDisplayNearestTo20();
        CountAndDisplaySpaces();
        CalculateAndDisplayArraySum();
        SwapAndDisplayNumbers();
        CalculateAndDisplayPower();
        DisplayFibonacciSeries();
        CalculateAndDisplayDigitSum();
    }
}