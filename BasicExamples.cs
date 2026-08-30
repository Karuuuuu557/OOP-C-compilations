using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# Basic Exercises ===\n");

        PersonalDetailsExercise();
        BmiCalculatorExercise();
        CharacterCheckExercise();
        MathFunctionsExercise();
        LeapYearExercise();
        ArithmeticExercise();
        ArrayExercise();

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
        EvenOddExercise();
        LargestNumberExercise();
        MultiplicationTableExercise();
        CalculatorExercise();
    }

    // =========================================================
    // 1. PERSONAL DETAILS
    // =========================================================

    static void PersonalDetailsExercise()
    {
        Console.WriteLine("\n1) Personal Details");

        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter your course: ");
        string course = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter your section: ");
        string section = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("\nFormatted Details:");
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Section: {section}");

        Console.WriteLine($"\nLength of the name: {fullName.Length} characters");
        Console.WriteLine($"Name in Uppercase: {fullName.ToUpper()}");
        Console.WriteLine($"Name in Lowercase: {fullName.ToLower()}");
    }


    // =========================================================
    // 2. BMI CALCULATOR
    // =========================================================

    static void BmiCalculatorExercise()
    {
        Console.WriteLine("\n2) BMI Calculator");

        Console.Write("Enter weight in kilograms: ");
        double weight = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter height in centimeters: ");
        int heightCm = int.Parse(Console.ReadLine() ?? "0");

        double heightInMeters = heightCm / 100.0;
        double bmi = weight / (heightInMeters * heightInMeters);

        string category = bmi < 18.5 ? "Underweight" :
                          bmi <= 24.9 ? "Normal" :
                          bmi <= 29.9 ? "Overweight" :
                          "Obese";

        Console.WriteLine($"Computed BMI: {bmi:F2}");
        Console.WriteLine($"BMI Category: {category}");
    }


    // =========================================================
    // 3. CHARACTER TYPE CHECKER
    // =========================================================

    static void CharacterCheckExercise()
    {
        Console.WriteLine("\n3) Character Type Checker");

        Console.Write("Enter a single character: ");
        string input = Console.ReadLine() ?? string.Empty;

        char character = input.Length > 0 ? input[0] : '\0';

        string result = character >= 'A' && character <= 'Z' ? "Capital Letter" :
                        character >= 'a' && character <= 'z' ? "Small Letter" :
                        character >= '0' && character <= '9' ? "Digit" :
                        "Special Symbol";

        Console.WriteLine($"The character '{character}' is a {result}");
        Console.WriteLine($"ASCII Value: {Convert.ToInt32(character)}");
    }


    // =========================================================
    // 4. MATH FUNCTIONS
    // =========================================================

    static void MathFunctionsExercise()
    {
        Console.WriteLine("\n4) Math Functions");

        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine() ?? "0");

        double squareRoot = Math.Sqrt(number);
        double square = Math.Pow(number, 2);
        double cube = Math.Pow(number, 3);
        double absolute = Math.Abs(number);
        double roundedValue = Math.Round(number);
        double sine = Math.Sin(number);
        double cosine = Math.Cos(number);
        double tangent = Math.Tan(number);

        Console.WriteLine($"Square root: {squareRoot:F2}");
        Console.WriteLine($"Square: {square:F2}");
        Console.WriteLine($"Cube: {cube:F2}");
        Console.WriteLine($"Absolute value: {absolute}");
        Console.WriteLine($"Rounded value: {roundedValue}");
        Console.WriteLine($"Sine: {sine:F2}");
        Console.WriteLine($"Cosine: {cosine:F2}");
        Console.WriteLine($"Tangent: {tangent:F2}");
    }


    // =========================================================
    // 5. LEAP YEAR CHECKER
    // =========================================================

    static void LeapYearExercise()
    {
        Console.WriteLine("\n5) Leap Year Checker");

        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine() ?? "0");

        bool isLeapYear = (year % 400 == 0) ||
                          (year % 4 == 0 && year % 100 != 0);

        Console.WriteLine(
            isLeapYear
                ? $"{year} is a leap year."
                : $"{year} is not a leap year."
        );
    }


    // =========================================================
    // 6. ARITHMETIC OPERATIONS
    // =========================================================

    static void ArithmeticExercise()
    {
        Console.WriteLine("\n6) Arithmetic Operations");

        Console.Write("Enter number 1: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        else
        {
            Console.WriteLine("Division and modulo by zero are not allowed.");
        }
    }


    // =========================================================
    // 7. ARRAY EXERCISE
    // =========================================================

    static void ArrayExercise()
    {
        Console.WriteLine("\n7) Array Exercise");

        Console.Write("Enter number of elements: ");
        int size = int.Parse(Console.ReadLine() ?? "0");

        if (size <= 0)
        {
            Console.WriteLine("Array must contain at least one element.");
            return;
        }

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("\nOriginal Array:");
        PrintArray(numbers);

        Console.WriteLine($"First element: {numbers[0]}");
        Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");

        int sum = SumArray(numbers);

        Console.WriteLine($"Sum of array elements: {sum}");

        Console.WriteLine("\nReversed Array:");
        PrintArray(ReverseArray(numbers));
    }


    // =========================================================
    // 8. USER-DEFINED FUNCTION
    // =========================================================

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("\n8) User-Defined Function");

        Console.WriteLine("Welcome Friends!");
        Console.WriteLine("Have a nice day!");
    }


    // =========================================================
    // 9. FUNCTION WITH PARAMETERS
    // =========================================================

    static void WelcomeFriend(string name)
    {
        Console.WriteLine($"Welcome friend {name}!");
        Console.WriteLine("Have a nice day!");
    }

    static void PrintPersonalizedWelcome()
    {
        Console.WriteLine("\n9) Function with Parameters");

        Console.Write("Please input a name: ");
        string name = Console.ReadLine() ?? string.Empty;

        WelcomeFriend(name);
    }


    // =========================================================
    // 10. FUNCTION WITH RETURN VALUE
    // =========================================================

    static int SumNumbers(int a, int b)
    {
        return a + b;
    }

    static void CalculateAndDisplaySum()
    {
        Console.WriteLine("\n10) Sum of Two Numbers");

        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum of two numbers is: {SumNumbers(a, b)}");
    }


    // =========================================================
    // 11. PRIME NUMBER CHECKER
    // =========================================================

    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void CheckAndDisplayPrimeNumber()
    {
        Console.WriteLine("\n11) Prime Number Checker");

        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
            Console.WriteLine($"{num} is a prime number.");
        else
            Console.WriteLine($"{num} is not a prime number.");
    }


    // =========================================================
    // 12. LOWERCASE TO UPPERCASE
    // =========================================================

    static char ToUpperCase(char letter)
    {
        return char.ToUpper(letter);
    }

    static void ConvertAndDisplayUpperCase()
    {
        Console.WriteLine("\n12) Convert Character to Uppercase");

        Console.Write("Input a character: ");
        char letter = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"Expected output: {ToUpperCase(letter)}");
    }


    // =========================================================
    // 13. NEAREST VALUE TO 20
    // =========================================================

    static int Near20(int a, int b)
    {
        if (a == b)
            return 0;

        if (Math.Abs(20 - a) < Math.Abs(20 - b))
            return a;

        return b;
    }

    static void FindAndDisplayNearestTo20()
    {
        Console.WriteLine("\n13) Find Nearest Value to 20");

        Console.Write("Input first integer: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input second integer: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Nearest value to 20: {Near20(a, b)}");
    }


    // =========================================================
    // 14. COUNT SPACES
    // =========================================================

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
        Console.WriteLine("\n14) Count Spaces in a String");

        Console.Write("Please input a string: ");
        string text = Console.ReadLine() ?? string.Empty;

        Console.WriteLine(
            $"\"{text}\" contains {CountSpaces(text)} spaces."
        );
    }


    // =========================================================
    // 15. SUM OF ARRAY
    // =========================================================

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
        Console.WriteLine("\n15) Sum of Array Elements");

        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(
            $"The sum of the elements of the array is {SumArray(numbers)}"
        );
    }


    // =========================================================
    // 16. SWAP USING REF
    // =========================================================

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SwapAndDisplayNumbers()
    {
        Console.WriteLine("\n16) Swap Two Numbers");

        Console.Write("Enter a number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Swap(ref a, ref b);

        Console.WriteLine(
            $"Now the 1st number is: {a}, and the 2nd number is: {b}"
        );
    }


    // =========================================================
    // 17. POWER FUNCTION
    // =========================================================

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
        Console.WriteLine("\n17) Raise a Number to a Power");

        Console.Write("Input base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            $"{number}^{exponent} = {Power(number, exponent)}"
        );
    }


    // =========================================================
    // 18. FIBONACCI SEQUENCE
    // =========================================================

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
        Console.WriteLine("\n18) Fibonacci Sequence");

        Console.Write("Input number of Fibonacci numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"The Fibonacci series of {n} numbers is: ");
        Fibonacci(n);

        Console.WriteLine();
    }


    // =========================================================
    // 19. SUM OF INDIVIDUAL DIGITS
    // =========================================================

    static int SumDigits(int num)
    {
        int sum = 0;

        num = Math.Abs(num);

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    static void CalculateAndDisplayDigitSum()
    {
        Console.WriteLine("\n19) Sum of Individual Digits");

        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            $"The sum of the digits of {num} is: {SumDigits(num)}"
        );
    }


    // =========================================================
    // 20. EVEN OR ODD
    // =========================================================

    static void EvenOddExercise()
    {
        Console.WriteLine("\n20) Even or Odd Checker");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (number % 2 == 0)
            Console.WriteLine($"{number} is even.");
        else
            Console.WriteLine($"{number} is odd.");
    }


    // =========================================================
    // 21. LARGEST NUMBER
    // =========================================================

    static void LargestNumberExercise()
    {
        Console.WriteLine("\n21) Largest Number");

        Console.Write("Enter number 1: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter number 2: ");
        int num2 = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter number 3: ");
        int num3 = int.Parse(Console.ReadLine() ?? "0");

        int largest = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine($"Largest number: {largest}");
    }


    // =========================================================
    // 22. MULTIPLICATION TABLE
    // =========================================================

    static void MultiplicationTableExercise()
    {
        Console.WriteLine("\n22) Multiplication Table");

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }


    // =========================================================
    // 23. SIMPLE CALCULATOR
    // =========================================================

    static void CalculatorExercise()
    {
        Console.WriteLine("\n23) Simple Calculator");

        Console.Write("Enter number 1: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine() ?? "+");

        Console.Write("Enter number 2: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        double result;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }

                result = num1 / num2;
                break;

            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }


    // =========================================================
    // HELPER METHODS
    // =========================================================

    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }

    static int[] ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }

        return reversed;
    }
}