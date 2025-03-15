using System;

class MyClass
{
    // 1. Static variable
    public static int staticVar = 10;

    // 3. Instance variable
    public int instanceVar;

    // 4. Changing static variable within class
    public void ChangeStaticValue(int newValue)
    {
        staticVar = newValue;
        Console.WriteLine("Static variable changed to: " + staticVar);
    }

    // 2. Static method
    public static void StaticMethod()
    {
        Console.WriteLine("Static method accessed.");
    }

    // 3. Instance Constructor
    public MyClass(int value)
    {
        instanceVar = value;
        Console.WriteLine("Instance Constructor called. InstanceVar = " + instanceVar);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------- 1. Access static variable through class name --------");
        Console.WriteLine("Static Variable Value: " + MyClass.staticVar);

        Console.WriteLine("\n-------- 2. Access static method through instance --------");
        MyClass obj1 = new MyClass(100);
        obj1.ChangeStaticValue(25);  // Changing static value
        obj1.StaticMethod();         // Not recommended, but possible

        Console.WriteLine("\n-------- 3. Instance constructor and variables --------");
        MyClass obj2 = new MyClass(200);

        Console.WriteLine("\n-------- 4. Modifying static variable within class --------");
        Console.WriteLine("StaticVar before change: " + MyClass.staticVar);
        obj2.ChangeStaticValue(999);
        Console.WriteLine("StaticVar after change: " + MyClass.staticVar);
    }
}
