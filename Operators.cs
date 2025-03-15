using System;

class OperatorsDemo
{
    static void Main()
    {
        Console.WriteLine("----- 1. Binary Arithmetic Operators -----");
        Console.Write("Enter value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition Operator: " + (a + b));
        Console.WriteLine("Subtraction Operator: " + (a - b));
        Console.WriteLine("Multiplication Operator: " + (a * b));
        Console.WriteLine("Division Operator: " + (a / b));
        Console.WriteLine("Modulo Operator: " + (a % b));

        Console.WriteLine("\n----- 2. Unary Arithmetic Operators -----");
        Console.Write("Enter a value for unary operation: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int res;

        res = x++; // Post increment
        Console.WriteLine("a is " + x + " and res is " + res);

        x = x - 1; // Reset to original
        res = x--; // Post decrement
        Console.WriteLine("a is " + x + " and res is " + res);

        x = x + 1; // Reset to original
        res = ++x; // Pre increment
        Console.WriteLine("a is " + x + " and res is " + res);

        res = --x; // Pre decrement
        Console.WriteLine("a is " + x + " and res is " + res);

        Console.WriteLine("\n----- 3. Relational Operators -----");
        Console.Write("Enter value for a: ");
        int relA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int relB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Equal to Operator (a == b): " + (relA == relB));
        Console.WriteLine("Greater than Operator (a > b): " + (relA > relB));
        Console.WriteLine("Less than Operator (a < b): " + (relA < relB));
        Console.WriteLine("Greater than or Equal to (a >= b): " + (relA >= relB));
        Console.WriteLine("Lesser than or Equal to (a <= b): " + (relA <= relB));
        Console.WriteLine("Not Equal to Operator (a != b): " + (relA != relB));
    }
}
