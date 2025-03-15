using System;

class Program
{
    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("This is a Static Method.");
    }

    // Instance method
    public void InstanceMethod()
    {
        Console.WriteLine("This is an Instance Method.");
    }

    // Calculator method
    public void Calculator(int a, int b)
    {
        int sum = a + b;
        int product = a * b;
        Console.WriteLine("Sum = " + sum + " and Product = " + product);
    }

    // Parameter array method
    public void PrintNames(params string[] names)
    {
        Console.WriteLine("Names passed using parameter array:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    // Method to print n even numbers
    public void PrintEvenNumbers(int count)
    {
        Console.WriteLine("First " + count + " even numbers:");
        int num = 2;
        for (int i = 0; i < count; i++)
        {
            Console.Write(num + " ");
            num += 2;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Program obj = new Program();

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. WriteLine(Boolean)");
        Console.WriteLine("2. Static and Instance Methods");
        Console.WriteLine("3. Calculator Method (Sum and Product)");
        Console.WriteLine("4. Parameter Array Example");
        Console.WriteLine("5. Print n Even Numbers");
        Console.Write("Enter your choice (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // WriteLine(Boolean)
                bool isTrue = (5 > 3);
                Console.WriteLine("Result of 5 > 3 is:");
                Console.WriteLine(isTrue);  // true
                break;

            case 2:
                // Static and instance methods
                StaticMethod();  // Calling static method
                obj.InstanceMethod(); // Calling instance method
                break;

            case 3:
                // Calculator method
                Console.Write("Enter value of a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter value of b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                obj.Calculator(a, b);
                break;

            case 4:
                // Parameter array
                obj.PrintNames("Kusuma", "Harsha", "Sravani", "Mounika");
                break;

            case 5:
                // Even number printer
                Console.Write("Enter number of even numbers to print: ");
                int n = Convert.ToInt32(Console.ReadLine());
                obj.PrintEvenNumbers(n);
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
