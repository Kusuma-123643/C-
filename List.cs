using System;
using System.Collections;
using System.Data;

class Program
{
    static void Main()
    {
        // 1. Create a datatable object
        DataTable dt1 = new DataTable();

        // 2. Create a datatable object with a name by using constructor
        DataTable dt2 = new DataTable("EmployeeTable");

        // 3. 10 Properties of DataTable (Print few, others as comments)
        Console.WriteLine("DataTable Name: " + dt2.TableName);
        Console.WriteLine("DataTable Columns Count: " + dt2.Columns.Count);
        Console.WriteLine("DataTable Rows Count: " + dt2.Rows.Count);
        // Other properties:
        // CaseSensitive, Constraints, DataSet, DefaultView, HasErrors, Locale, Namespace, Prefix

        // 4. 10 Methods of DataTable (Used / Mentioned)
        // Columns.Add(), Rows.Add(), AcceptChanges(), Clear(), Clone(), Copy(), NewRow(), Select(), ImportRow(), Compute()

        // 5. Add 4 columns using Columns.Add()
        dt2.Columns.Add("EmpId", typeof(int));
        dt2.Columns.Add("EmpName", typeof(string));
        dt2.Columns.Add("EmpSalary", typeof(double));
        dt2.Columns.Add("Department", typeof(string));

        // 6. Add 5 records using Rows.Add()
        dt2.Rows.Add(101, "Kiran", 50000, "HR");
        dt2.Rows.Add(102, "Anu", 60000, "IT");
        dt2.Rows.Add(103, "Ravi", 55000, "Finance");
        dt2.Rows.Add(104, "Divya", 62000, "IT");
        dt2.Rows.Add(105, "Kishore", 48000, "HR");

        // 7. Print EmpId using for loop
        Console.WriteLine("\nEmpId using for loop:");
        for (int i = 0; i < dt2.Rows.Count; i++)
        {
            Console.WriteLine(dt2.Rows[i]["EmpId"]);
        }

        // 8. Print EmpId using foreach loop
        Console.WriteLine("\nEmpId using foreach loop:");
        foreach (DataRow row in dt2.Rows)
        {
            Console.WriteLine(row["EmpId"]);
        }

        // 9. Print EmpId using DataRow property
        Console.WriteLine("\nEmpId using DataRow properties:");
        foreach (DataRow row in dt2.Rows)
        {
            int id = row.Field<int>("EmpId");
            Console.WriteLine(id);
        }

        // 10. Create another datatable with 5 columns and 4 records
        DataTable dt3 = new DataTable("StudentTable");
        dt3.Columns.Add("StudentId", typeof(int));
        dt3.Columns.Add("StudentName", typeof(string));
        dt3.Columns.Add("Age", typeof(int));
        dt3.Columns.Add("Course", typeof(string));
        dt3.Columns.Add("Marks", typeof(double));

        dt3.Rows.Add(1, "Ram", 20, "Maths", 85);
        dt3.Rows.Add(2, "Sita", 19, "Physics", 90);
        dt3.Rows.Add(3, "Laxman", 21, "Chemistry", 88);
        dt3.Rows.Add(4, "Hanuman", 22, "Biology", 95);

        // 11. Create a DataSet object
        DataSet ds = new DataSet();

        // 12. Create a DataSet with name
        DataSet myDataSet = new DataSet("MyDataSet");

        // 13. Add tables to DataSet
        myDataSet.Tables.Add(dt2);
        myDataSet.Tables.Add(dt3);

        Console.WriteLine("\nTables in MyDataSet:");
        foreach (DataTable table in myDataSet.Tables)
        {
            Console.WriteLine(table.TableName);
        }

        // 14. 3 Properties of ArrayList
        Console.WriteLine("\nArrayList Properties:");
        ArrayList al = new ArrayList();
        Console.WriteLine("IsFixedSize: " + al.IsFixedSize);
        Console.WriteLine("IsReadOnly: " + al.IsReadOnly);
        Console.WriteLine("Capacity: " + al.Capacity);

        // 15. 3 Methods of ArrayList: Add(), Clear(), Reverse(), Sort(), Remove()
        // Used below.

        // 16. Difference between Array and ArrayList
        Console.WriteLine("\nArray vs ArrayList:");
        Console.WriteLine("Array: Fixed size, same data type");
        Console.WriteLine("ArrayList: Dynamic size, can hold mixed data types");

        // 17. Create ArrayList and add 3 strings
        ArrayList myList = new ArrayList();
        myList.Add("One");
        myList.Add("Two");
        myList.Add("Three");

        // 18. Print using for and foreach
        Console.WriteLine("\nArrayList using for loop:");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }

        Console.WriteLine("\nArrayList using foreach loop:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        // 19. Remove all using Clear
        myList.Clear();
        Console.WriteLine("\nArrayList count after Clear(): " + myList.Count);

        // Re-add for reverse and sort
        myList.Add("Banana");
        myList.Add("Apple");
        myList.Add("Cherry");

        // 20. Reverse elements
        myList.Reverse();
        Console.WriteLine("\nArrayList after Reverse():");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        // 21. Sort elements
        myList.Sort();
        Console.WriteLine("\nArrayList after Sort():");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n--- End of Program ---");
    }
}
