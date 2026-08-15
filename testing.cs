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
    static void displayElements(int[] arr)
    {
        Console.WriteLine("\nOriginal Array");
        Console.WriteLine(string.Join(", ", arr)); //gets the arrays content and prints in one single line
    }

    static void accessFirstLast()
    {
        Console.WriteLine($"The first element is: {arr[0]}. The last element is {arr[arr.Length - 1]}");
    }
}