using System;

class Program
{
    static void Main()
    {
        // 1. Declare a variable of data type int with name empID
        int empID;

        // 2. Declare a variable of data type string with name empName
        string empName;

        // 3. Assign a value 5 for the empId variable and print the value of empId on console
        empID = 5;
        Console.WriteLine("Employee ID: " + empID);

        // 4. Assign a value "Puja" for the empName variable and print the value of empName on console
        empName = "Puja";
        Console.WriteLine("Employee Name: " + empName);

        // 5. Write a program to check whether it is odd or even
        Console.WriteLine("\nEnter a number to check odd or even:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is even");
        }
        else
        {
            Console.WriteLine(num + " is odd");
        }

        // 6. Write a program to swap 2 numbers
        Console.WriteLine("\nEnter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before Swapping: a = " + a + ", b = " + b);

        // Swapping logic
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After Swapping: a = " + a + ", b = " + b);
    }
}
