using System;

class BasicInputs
{
    static void Main()
    {
        // 1. Create any value called EmpName and print that value in the output
        string EmpName = "Puja";
        Console.WriteLine("1. Employee Name is: " + EmpName);

        // 2. Declare a variable name of any datatype and read the name in the output
        Console.WriteLine("\n2. Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("You entered: " + name);

        // 3. Enter your name from WriteLine function and print the output
        Console.WriteLine("\n3. Your name is printed using WriteLine function:");
        Console.WriteLine("Name: Kusuma");

        // 4. Declare 2 strings and concatenate with another string
        Console.WriteLine("\n4. Enter your first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        string fullGreeting = "Hello " + firstName + " " + lastName;
        Console.WriteLine("Output: " + fullGreeting);

        // 5. Add two integers and print the result
        Console.WriteLine("\n5. Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine("Sum is: " + sum);

        // 6. Enter password as char array, convert to string and print
        Console.WriteLine("\n6. Enter your password:");
        char[] passwordChars = Console.ReadLine().ToCharArray();
        string password = new string(passwordChars);
        Console.WriteLine("Password: " + password);

        // Keep console open
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
