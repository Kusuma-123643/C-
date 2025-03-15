using System;

class OverloadingDemo
{
    // 1. Overloading by changing number of parameters
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    public void Greet(string name, int age)
    {
        Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");
    }

    // 2. Overloading by changing the order of parameters
    public void Info(string city, int pincode)
    {
        Console.WriteLine("City: " + city + ", Pincode: " + pincode);
    }

    public void Info(int pincode, string city)
    {
        Console.WriteLine("Pincode: " + pincode + ", City: " + city);
    }

    // 3. Sum function accepting parameters and printing their addition
    public void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, result);
    }

    public void Sum(int a, int b, int c)
    {
        int result = a + b + c;
        Console.WriteLine("Sum of {0}, {1}, and {2} is: {3}", a, b, c, result);
    }

    // 4. Division function with multiple parameters
    public void Division(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division of {0} by {1} is: {2}", a, b, a / b);
        else
            Console.WriteLine("Cannot divide by zero.");
    }

    public void Division(double a, double b)
    {
        if (b != 0)
            Console.WriteLine("Division of {0} by {1} is: {2:F2}", a, b, a / b);
        else
            Console.WriteLine("Cannot divide by zero.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        OverloadingDemo obj = new OverloadingDemo();

        Console.WriteLine("---- 1. Overloading by Changing Number of Parameters ----");
        obj.Greet();
        obj.Greet("Kusuma");
        obj.Greet("Kusuma", 21);

        Console.WriteLine("\n---- 2. Overloading by Changing Order of Parameters ----");
        obj.Info("Srikakulam", 532001);
        obj.Info(532001, "Srikakulam");

        Console.WriteLine("\n---- 3. Sum Function ----");
        obj.Sum(10, 20);
        obj.Sum(5, 10, 15);

        Console.WriteLine("\n---- 4. Division Function ----");
        obj.Division(10, 2);
        obj.Division(20.5, 2.5);
        obj.Division(10, 0); // Test divide by zero
    }
}
