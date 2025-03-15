using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmpSalary { get; set; }
    public int DeptId { get; set; }
}

class Program
{
    static void Main()
    {
        // 1. Create a list of 10 employee objects
        List<Employee> empList = new List<Employee>()
        {
            new Employee{ EmpId = 1, EmpName = "Kishore", EmpSalary = 1000, DeptId = 2 },
            new Employee{ EmpId = 2, EmpName = "Ravi", EmpSalary = 1500, DeptId = 1 },
            new Employee{ EmpId = 3, EmpName = "Kishore", EmpSalary = 1000, DeptId = 3 },
            new Employee{ EmpId = 4, EmpName = "Anil", EmpSalary = 2500, DeptId = 4 },
            new Employee{ EmpId = 5, EmpName = "Sita", EmpSalary = 3000, DeptId = 2 },
            new Employee{ EmpId = 6, EmpName = "Raju", EmpSalary = 3500, DeptId = 5 },
            new Employee{ EmpId = 7, EmpName = "Priya", EmpSalary = 4000, DeptId = 6 },
            new Employee{ EmpId = 8, EmpName = "Vamsi", EmpSalary = 2200, DeptId = 4 },
            new Employee{ EmpId = 9, EmpName = "Anu", EmpSalary = 5000, DeptId = 7 },
            new Employee{ EmpId = 10, EmpName = "Sai", EmpSalary = 1800, DeptId = 3 }
        };

        Console.WriteLine("\n1. Employees with name = Kishore:");
        var kishores = empList.Where(e => e.EmpName == "Kishore").Distinct();
        foreach (var emp in kishores)
            PrintEmp(emp);

        Console.WriteLine("\n2. Employee with EmpId = 4:");
        var empId4 = empList.Where(e => e.EmpId == 4).Distinct();
        foreach (var emp in empId4)
            PrintEmp(emp);

        Console.WriteLine("\n3. Employees with DeptId = 4:");
        var deptId4 = empList.Where(e => e.DeptId == 4).Distinct();
        foreach (var emp in deptId4)
            PrintEmp(emp);

        Console.WriteLine("\n4. Copy entire list to new list:");
        var copiedList = new List<Employee>(empList);
        foreach (var emp in copiedList)
            PrintEmp(emp);

        Console.WriteLine("\n5. Copy only employees named Kishore:");
        var kishoreList = empList.Where(e => e.EmpName == "Kishore").ToList();
        foreach (var emp in kishoreList)
            PrintEmp(emp);

        Console.WriteLine("\n6. Employees with salary > 2000:");
        var salaryList = empList.Where(e => e.EmpSalary > 2000).ToList();
        Console.WriteLine("Count: " + salaryList.Count);
        foreach (var emp in salaryList)
            PrintEmp(emp);

        Console.WriteLine("\n7. Using Select - DeptId = 4:");
        var selectDept4 = empList.Select(e => e).Where(e => e.DeptId == 4);
        foreach (var emp in selectDept4)
            PrintEmp(emp);

        Console.WriteLine("\n8. Using Contains (Note: Contains works with object equality, needs custom comparer or checking values):");
        bool dept4Exists = empList.Any(e => e.DeptId == 4);
        if (dept4Exists)
        {
            var dept4 = empList.Where(e => e.DeptId == 4);
            foreach (var emp in dept4)
                PrintEmp(emp);
        }

        Console.WriteLine("\n9. Distinct Employee Names count:");
        var distinctNames = empList.Select(e => e.EmpName).Distinct().ToList();
        Console.WriteLine("Distinct Names Count: " + distinctNames.Count);
        foreach (var name in distinctNames)
            Console.WriteLine(name);

        Console.WriteLine("\n10. Convert Integer Array to List:");
        int[] arr = { 10, 20, 30, 40, 50 };
        List<int> intList = arr.ToList();
        intList.ForEach(i => Console.WriteLine(i));

        Console.WriteLine("\n11. First Employee using First():");
        var firstEmp = empList.First();
        PrintEmp(firstEmp);

        Console.WriteLine("\n12. First Employee using FirstOrDefault():");
        var firstOrDefaultEmp = empList.FirstOrDefault();
        PrintEmp(firstOrDefaultEmp);

        Console.WriteLine("\n13. Single Employee using Single() (only if list has exactly one element matching condition):");
        try
        {
            var singleEmp = empList.Single(e => e.EmpId == 2);
            PrintEmp(singleEmp);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error using Single(): " + ex.Message);
        }

        Console.WriteLine("\n14. SingleOrDefault Employee:");
        var singleOrDefault = empList.SingleOrDefault(e => e.EmpId == 5);
        PrintEmp(singleOrDefault);

        Console.WriteLine("\n15. Sort by EmpId using OrderBy:");
        var sortedById = empList.OrderBy(e => e.EmpId);
        foreach (var emp in sortedById)
            PrintEmp(emp);

        Console.WriteLine("\n16. Sort by EmpName using OrderBy:");
        var sortedByName = empList.OrderBy(e => e.EmpName);
        foreach (var emp in sortedByName)
            PrintEmp(emp);

        Console.WriteLine("\n17. Sort by EmpName and then reverse by EmpId:");
        var sorted = empList.OrderBy(e => e.EmpName).ThenByDescending(e => e.EmpId);
        foreach (var emp in sorted)
            PrintEmp(emp);
    }

    static void PrintEmp(Employee emp)
    {
        Console.WriteLine($"EmpId: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.EmpSalary}, DeptId: {emp.DeptId}");
    }
}
