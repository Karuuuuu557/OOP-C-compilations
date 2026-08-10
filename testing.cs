//this file is for testing the block of code only, it is not part of the main program

using System;
using System.Formats.Asn1;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
            Console.WriteLine("The number is zero.");
        else if (number % 2 == 0)
            Console.WriteLine("The number is even.");
        else
            Console.WriteLine("The number is odd.");
    }
}