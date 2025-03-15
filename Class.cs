using System;

class Employee
{
    public int EmpId;
    public string Name;
    public string Designation;

    // Constructor with parameters
    public Employee(int id, string name, string desig)
    {
        EmpId = id;
        Name = name;
        Designation = desig;
    }

    public void PrintEmployee()
    {
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine("ID: " + EmpId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Designation: " + Designation);
    }
}

// Overloading constructor example
class OverloadDemo
{
    public int A;
    public string B;

    // Default constructor
    public OverloadDemo()
    {
        A = 0;
        B = "Default";
    }

    // Overloaded constructor
    public OverloadDemo(int a)
    {
        A = a;
        B = "Only A";
    }

    // Another overloaded constructor
    public OverloadDemo(int a, string b)
    {
        A = a;
        B = b;
    }

    public void Show()
    {
        Console.WriteLine($"A: {A}, B: {B}");
    }
}

// Car class
class Car
{
    public string color;
    public int maxSpeed;
    public string brand;

    // Method to display car info
    public void ShowDetails()
    {
        Console.WriteLine($"Brand: {brand}, Color: {color}, Max Speed: {maxSpeed}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------- Employee Class Using Constructor --------");
        Employee emp = new Employee(101, "Kusuma", "Developer");
        emp.PrintEmployee();

        Console.WriteLine("\n-------- Constructor Overloading --------");
        OverloadDemo obj1 = new OverloadDemo();
        OverloadDemo obj2 = new OverloadDemo(10);
        OverloadDemo obj3 = new OverloadDemo(20, "Custom");
        obj1.Show();
        obj2.Show();
        obj3.Show();

        Console.WriteLine("\n-------- Car Class and Fields --------");
        Car myObj = new Car();
        myObj.brand = "Toyota";
        myObj.color = "Red";
        myObj.maxSpeed = 180;
        Console.WriteLine("Car Color: " + myObj.color);
        Console.WriteLine("Car Max Speed: " + myObj.maxSpeed);
        myObj.ShowDetails();

        Console.WriteLine("\n-------- Multiple Objects from One Class --------");
        Car car1 = new Car();
        car1.brand = "Hyundai";
        car1.color = "Blue";
        car1.maxSpeed = 160;

        Car car2 = new Car();
        car2.brand = "Suzuki";
        car2.color = "White";
        car2.maxSpeed = 140;

        car1.ShowDetails();
        car2.ShowDetails();
    }
}
