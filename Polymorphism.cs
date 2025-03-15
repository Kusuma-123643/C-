using System;

class OverloadingExample
{
    // 1. Two Add methods with different number of parameters
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition of 2 values: " + (a + b));
    }

    public void Add(int a, int b, int c)
    {
        Console.WriteLine("Addition of 3 values: " + (a + b + c));
    }

    // 3. Method with same name but different signature
    public void Show(string name)
    {
        Console.WriteLine("Hello, " + name);
    }

    public void Show(int id)
    {
        Console.WriteLine("ID is: " + id);
    }

    // 4. Overloading by changing data types
    public void Display(int num)
    {
        Console.WriteLine("Integer: " + num);
    }

    public void Display(double num)
    {
        Console.WriteLine("Double: " + num);
    }

    // 5. Overloading by changing order of parameters
    public void Order(int a, string b)
    {
        Console.WriteLine("Order: int first then string - " + a + ", " + b);
    }

    public void Order(string b, int a)
    {
        Console.WriteLine("Order: string first then int - " + b + ", " + a);
    }
}

// 2. Runtime Polymorphism Example
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- 1. Method Overloading (Different Parameters) -----");
        OverloadingExample obj = new OverloadingExample();
        obj.Add(5, 10);
        obj.Add(1, 2, 3);

        Console.WriteLine("\n----- 2. Runtime Polymorphism -----");
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        a1.Speak();
        a2.Speak();

        Console.WriteLine("\n----- 3. Method Overloading (Different Signatures) -----");
        obj.Show("Kusuma");
        obj.Show(123);

        Console.WriteLine("\n----- 4. Overloading by Changing Data Types -----");
        obj.Display(100);
        obj.Display(45.67);

        Console.WriteLine("\n----- 5. Overloading by Changing Order of Parameters -----");
        obj.Order(1, "Hello");
        obj.Order("Hi", 2);
    }
}
