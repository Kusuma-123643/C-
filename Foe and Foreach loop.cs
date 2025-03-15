using System;

class AllInOneProgram
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Display n Natural Numbers and their Sum");
        Console.WriteLine("2. Display n Odd Natural Numbers and their Sum");
        Console.WriteLine("3. Print Array using For and ForEach loop");
        Console.Write("Enter your choice (1/2/3): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Natural numbers and their sum
                Console.Write("Enter number of natural terms you want: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                Console.Write("The first " + n + " natural numbers are: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine("\nThe Sum of Natural Numbers up to " + n + " terms: " + sum);
                break;

            case 2:
                // Odd numbers and their sum
                Console.Write("Enter number of odd natural terms you want: ");
                int terms = Convert.ToInt32(Console.ReadLine());
                int oddSum = 0;
                int count = 0;
                int number = 1;

                Console.Write("The odd numbers are: ");
                while (count < terms)
                {
                    Console.Write(number + " ");
                    oddSum += number;
                    number += 2;
                    count++;
                }
                Console.WriteLine("\nThe Sum of odd Natural Numbers up to " + terms + " terms: " + oddSum);
                break;

            case 3:
                // Array printing using For and Foreach loop
                string[] arr = { "JalaTechnologies" };

                Console.WriteLine("Array printing using for loop:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                Console.WriteLine("Array printing using foreach loop:");
                foreach (string item in arr)
                {
                    Console.WriteLine(item);
                }
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                break;
        }
    }
}
