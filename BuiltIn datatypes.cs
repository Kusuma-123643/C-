using System;

class Basics
{
    static void Main()
    {
        // 1. Declare a value as int datatype and print in the output
        int number = 10;
        Console.WriteLine("1. Integer value: " + number);

        // 2. Boolean type and print in console
        bool isPassed = true;
        Console.WriteLine("\n2. Boolean value: " + isPassed);

        // 3. Convert Float to Decimal and print in console
        float floatValue = 23.45f;
        decimal decimalValue = (decimal)floatValue;
        Console.WriteLine("\n3. Float to Decimal: " + decimalValue);

        // 4. Take 2 numbers and perform an operation
        Console.WriteLine("\n4. Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose operation (+, -, *, /):");
        char op = Convert.ToChar(Console.ReadLine());

        int result = 0;
        if (op == '+') result = a + b;
        else if (op == '-') result = a - b;
        else if (op == '*') result = a * b;
        else if (op == '/') result = a / b;
        else Console.WriteLine("Invalid operation");

        if (op == '+' || op == '-' || op == '*' || op == '/')
            Console.WriteLine("Result: " + a + " " + op + " " + b + " = " + result);

        // 5. Take 3 letters and print in reverse order
        Console.WriteLine("\n5. Enter three letters:");
        Console.Write("Letter 1: ");
        char l1 = Convert.ToChar(Console.ReadLine());
        Console.Write("Letter 2: ");
        char l2 = Convert.ToChar(Console.ReadLine());
        Console.Write("Letter 3: ");
        char l3 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Reversed: " + l3 + " " + l2 + " " + l1);

        // 6. Check if input character is vowel, digit or symbol
        Console.WriteLine("\n6. Enter a character:");
        char ch = Convert.ToChar(Console.ReadLine());

        if (ch >= 'a' && ch <= 'z')
        {
            if ("aeiou".Contains(ch))
                Console.WriteLine("It is a lowercase vowel");
            else
                Console.WriteLine("It is a lowercase consonant");
        }
        else if (char.IsDigit(ch))
        {
            Console.WriteLine("It is a digit");
        }
        else
        {
            Console.WriteLine("It is a symbol");
        }

        // End
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
