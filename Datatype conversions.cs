using System;

class TypeConversionDemo
{
    static void Main()
    {
        // 1. Implicit Type Conversion
        Console.WriteLine("----- 1. Implicit Type Conversion -----");
        Console.Write("Enter Int value: ");
        int intVal = Convert.ToInt32(Console.ReadLine());
        long longVal = intVal;  // Implicit conversion from int to long
        Console.WriteLine("Int value - " + intVal);
        Console.WriteLine("Long value - " + longVal);

        // 2. Explicit Type Conversion
        Console.WriteLine("\n----- 2. Explicit Type Conversion -----");
        Console.Write("Enter Double value: ");
        double d = Convert.ToDouble(Console.ReadLine());
        int i = (int)d;  // Explicit conversion
        Console.WriteLine("Value of i is " + i);

        // 3. Built-in Type Conversion Methods
        Console.WriteLine("\n----- 3. Built-in Type Conversion Methods -----");
        Console.Write("Enter a string number (e.g., 34.6): ");
        string str = Console.ReadLine();
        float floatVal = float.Parse(str); // String to float

        Console.Write("Enter Integer value: ");
        int num = Convert.ToInt32(Console.ReadLine());
        double doubleVal = Convert.ToDouble(num); // Int to double

        Console.WriteLine("string to float - " + floatVal);
        Console.WriteLine("int to double - " + doubleVal);

        // 4. Value Types to String Conversion
        Console.WriteLine("\n----- 4. Value Types to String Conversion -----");
        Console.Write("Enter Integer value: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Float value: ");
        float floatNum = float.Parse(Console.ReadLine());

        Console.WriteLine("int.ToString() - " + number.ToString());
        Console.WriteLine("float.ToString() - " + floatNum.ToString("0.00"));
    }
}
