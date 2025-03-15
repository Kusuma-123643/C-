using System;

class Employee
{
    // 1. Read-only property
    private int empId;
    public int EmpId
    {
        get { return empId; }
    }

    public Employee(int id)
    {
        empId = id; // Value set only in constructor
    }
}

class Person
{
    // 2. Read and Write property using get and set
    public string Name { get; set; }
    public int Age { get; set; }
}

// 3. EmployeeModel with 5 properties
class EmployeeModel
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmailId { get; set; }
    public float Salary { get; set; }
    public bool IsEmployeeActive { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- 1. Read-Only Property -----");
        Employee emp1 = new Employee(101);
        Console.WriteLine("Employee ID (Read-only): " + emp1.EmpId);

        Console.WriteLine("\n----- 2. Read and Write Property -----");
        Person p = new Person();
        p.Name = "Kusuma";
        p.Age = 21;
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Age: " + p.Age);

        Console.WriteLine("\n----- 3, 4 & 5. EmployeeModel Objects -----");

        // 4. First object of EmployeeModel
        EmployeeModel empObj1 = new EmployeeModel();
        empObj1.EmpId = 201;
        empObj1.EmpName = "Anusha";
        empObj1.EmailId = "anusha@gmail.com";
        empObj1.Salary = 45000.5f;
        empObj1.IsEmployeeActive = true;

        Console.WriteLine("\n-- First Employee Details --");
        Console.WriteLine("EmpId: " + empObj1.EmpId);
        Console.WriteLine("Name: " + empObj1.EmpName);
        Console.WriteLine("Email: " + empObj1.EmailId);
        Console.WriteLine("Salary: " + empObj1.Salary);
        Console.WriteLine("Active: " + empObj1.IsEmployeeActive);

        // 5. Second object of EmployeeModel
        EmployeeModel empObj2 = new EmployeeModel();
        empObj2.EmpId = 202;
        empObj2.EmpName = "Harsha";
        empObj2.EmailId = "harsha@yahoo.com";
        empObj2.Salary = 52000.75f;
        empObj2.IsEmployeeActive = false;

        Console.WriteLine("\n-- Second Employee Details --");
        Console.WriteLine("EmpId: " + empObj2.EmpId);
        Console.WriteLine("Name: " + empObj2.EmpName);
        Console.WriteLine("Email: " + empObj2.EmailId);
        Console.WriteLine("Salary: " + empObj2.Salary);
        Console.WriteLine("Active: " + empObj2.IsEmployeeActive);
    }
}
