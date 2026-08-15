//this file is for testing the block of code only, it is not part of the main program
using System;

class Program
{
    /*
INSTRUCTIONS:
1.	Display the Elements
2.	Access Array Elements (First and Last)
3.	Add an Element to the Array
4.	Modify an Array Element 
5.	Remove an Element from the Array
6.	Calculate and Print the Sum of Array Elements
7.	Reverse the Array
*/
    static void Main()
    {
        //ML 2 : Array
    Console.WriteLine("Enter number of elements: ");
    int size = int.Parse(Console.ReadLine());

    int [] myArray = new int[size];

    Console.WriteLine("Enter the elements of the array:");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Element {i + 1}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }


// 1. Display the Elements
    Console.WriteLine("\nOriginal Array");
    PrintArray(myArray);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}
