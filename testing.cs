 Console.WriteLine("Checking if a Number is Positive, Negative, or Zero (using the ternary operator)");

         Console.Write("Enter a Number: ");
         int ternaryNum = int.Parse(Console.ReadLine());

         string result = (ternaryNum > 0) ? "Postive" : (ternaryNum < 0) ? "Negative" : "Zero";
         Console.WriteLine($"The number {ternaryNum} is {result}");