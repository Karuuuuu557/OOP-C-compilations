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
    }

    static void PersonalDetailsExercise()
    {
        Console.WriteLine("1) Personal Details");
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

    static void LeapYearExercise()
    {
        Console.WriteLine("\n5) Leap Year Checker");
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine() ?? "0");

        bool isLeapYear = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        Console.WriteLine(isLeapYear ? $"{year} is a leap year." : $"{year} is not a leap year.");
    }

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
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
    }

    static void ArrayExercise()
    {
        Console.WriteLine("\n7) Array Exercise");
        Console.Write("Enter number of elements: ");
        int size = int.Parse(Console.ReadLine() ?? "0");

        int[] numbers = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("\nOriginal Array:");
        PrintArray(numbers);

        Console.WriteLine($"\nFirst element: {numbers[0]}");
        Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");

        int sum = 0;
        foreach (int value in numbers)
        {
            sum += value;
        }

        Console.WriteLine($"Sum of array elements: {sum}");

        Console.WriteLine("\nReversed Array:");
        PrintArray(ReverseArray(numbers));
    }

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
