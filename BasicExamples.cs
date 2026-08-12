using System;

class Program
{
    static void Main(string[] args)
    {
/* 1.	Write a C# program that asks the user to input the following details:
•	Full Name (string)
•	Age (integer)
•	Course (string)
•	Section (string)
Then, the program should:
a)	Display the inputted details in a formatted way.
b)	Show the length of the name (number of characters).
c)	Convert and display the name in uppercase and lowercase.*/

        Console.WriteLine("Enter your full name: ");
        string fName = Console.ReadLine();

        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your course: ");
        string course = Console.ReadLine();

        Console.WriteLine("Enter your section: ");
        string section = Console.ReadLine();

//Part (a) display the inputted details in a formatted way

        Console.WriteLine("\nFormatted Details:");
        Console.WriteLine($"Full Name: {fName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Course: {course}");
        Console.WriteLine($"Section: {section}");

//Part (b) show the length of the name (number of characters)

        int nameLength = fName.Length;
        Console.WriteLine($"\nLength of the name: {nameLength} characters");

//Part (c) convert and display the name in uppercase and lowercase

        string upperName = fName.ToUpper();
        string lowerName = fName.ToLower();

        Console.WriteLine($"\nName in Uppercase: {upperName}");
        Console.WriteLine($"Name in Lowercase: {lowerName}");

/* 2.	Write a C# program that:
1.	Asks the user to input their weight in kilograms (can be decimal).
2.	Asks the user to input their height in centimeters (integer).
3.	Converts the height from centimeters to meters.
4.	Computes the BMI using the formula:
BMI = weight / (height in meters)^2
 
Displays the computed BMI and determines the category:
o	BMI < 18.5 → Underweight
o	BMI 18.5 – 24.9 → Normal
o	BMI 25 – 29.9 → Overweight
o	BMI ≥ 30 → Obese */

// 1. Ask the user to input their weight in kilograms (can be decimal).
    Console.WriteLine("\n Enter Weight in Kilograms (can include decimal): ");
    double weight = double.Parse(Console.ReadLine());
// 2. Ask the user to input their height in centimeters (integer).
    Console.WriteLine("Enter Height in Centimeters (integer): ");
    int heightCm = int.Parse(Console.ReadLine());
// 3. Convert the height from centimeters to meters.
    double heightM = heightCm / 100.0;
// 4. Compute the BMI using the formula: BMI = weight / (height in meters)^2
    double BMI = weight / Math.Pow(heightM, 2);
// Display the computed BMI and determine the category
    Console.WriteLine($"\nComputed BMI: {BMI:F2}");

    string category = 
    (BMI < 18.5) ? "Underweight" :
    (BMI <= 24.9) ? "Normal" :
    (BMI <= 29.9) ? "Overweight" : 
    "Obese";

    Console.WriteLine($"BMI Category: {category}");

/*3.	Write a C# program that:
a)	Asks the user to input a single character.
b)	Determines whether the character is:
a.	A capital letter (A–Z)
b.	A small letter (a–z)
c.	A digit (0–9)
d.	A special symbol (anything else)
c)	Displays the ASCII value of the character.

ASCII Table Reference
•	Capital letters A–Z → ASCII 65 to 90
•	Small letters a–z → ASCII 97 to 122
•	Digits 0–9 → ASCII 48 to 57
•	Special symbols → all other values */

    Console.WriteLine("\nEnter a Single Character: ");
    char oneChar = Console.ReadLine()[0]; //char syntax must have [0] to get the first character of the string input
    
    string result = (oneChar >= 'A' && oneChar <= 'Z') ? "Capital Letter" :
                    (oneChar >= 'a' && oneChar <= 'z') ? "Small Letter" :
                    (oneChar >= '0' && oneChar <= '9') ? "Digit" :
                    "Special Symbol";

    Console.WriteLine($"The character '{oneChar}' is a {result}");
    Console.WriteLine($"ASCII Value: {Convert.ToInt32(oneChar)}");

/* 4.	Write a C# program that:
a)	Accepts a number from the user.
b)	Uses math functions to compute and display:
a.	Square root (Math.Sqrt)
b.	Square and cube (Math.Pow)
c.	Absolute value (Math.Abs)
d.	Rounded value (Math.Round)
e.	Sine, Cosine, Tangent (Math.Sin, Math.Cos, Math.Tan)*/

    Console.WriteLine("\nEnter a Number: ");
    double number = double.Parse(Console.ReadLine());
//square root the number
    double squareRoot = Math.Sqrt(number);
//number input to the power of 2
    double square = Math.Pow(number, 2);
//number input to the power of 3
    double cube = Math.Pow(number, 3);
//the absolute value of the number
    double absolute = Math.Abs(number);
// Rounds the number to the nearest whole number
    double roundedValue = Math.Round(number);
 // Calculates the sine of the number in radians
    double sine = Math.Sin(number);
 // Calculates the cosine of the number in radians
    double cosine = Math.Cos(number);
 // Calculates the tangent of the number in radians
    double tangent = Math.Tan(number);

    Console.WriteLine($"The square root of {number} is: {squareRoot:F2}");
    Console.WriteLine($"The square of {number} is: {square:F2}");
    Console.WriteLine($"The cube of {number} is: {cube:F2}");
    Console.WriteLine($"The absolute value of {number} is: {absolute}");
    Console.WriteLine($"The rounded value of {number} is: {roundedValue}");
    Console.WriteLine($"The sine of {number} is: {sine:F2}");
    Console.WriteLine($"The cosine of {number} is: {cosine:F2}");
    Console.WriteLine($"The tangent of {number} is: {tangent:F2}");

/* 5.	Write a C# program that asks the user to enter a year.
•	If divisible by 400 → Leap year
•	Else if divisible by 100 → Not a leap year
•	Else if divisible by 4 → Leap year
•	Else → Not a leap year */

Console.WriteLine("Check if year inputted is a leap year or not");

        Console.Write("Enter a Year: ");
        int year = int.Parse(Console.Readline());
//checks the year inputted checks the three criteria mentioned
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{year} is a leap year.");
        }
        else
        {
            Console.WriteLine("{year} is not a Leap year.");
        }
    }
}
