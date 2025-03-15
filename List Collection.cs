using System;
using System.Collections.Generic;

namespace ListOperationsDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}");
        }

        // Override Equals for Contains to work properly
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Student other = (Student)obj;
            return Id == other.Id && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== List Properties (Conceptual) =====");
            Console.WriteLine("1. Count\n2. Capacity\n3. Item[int index]\n4. IsReadOnly\n5. ICollection Interface");

            Console.WriteLine("\n===== List Methods (Conceptual) =====");
            Console.WriteLine("1. Add()\n2. Remove()\n3. Clear()\n4. Contains()\n5. Insert()");

            Console.WriteLine("\n===== Integer List =====");
            List<int> intList = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < intList.Count; i++)
                Console.Write(intList[i] + " ");

            Console.WriteLine("\nUsing foreach loop:");
            foreach (int item in intList)
                Console.Write(item + " ");

            Console.WriteLine("\n\n===== String List =====");
            List<string> strList = new List<string> { "Kiran", "Anu", "Ravi", "Kishore", "Divya" };

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < strList.Count; i++)
                Console.Write(strList[i] + " ");

            Console.WriteLine("\nUsing foreach loop:");
            foreach (string s in strList)
                Console.Write(s + " ");

            Console.WriteLine($"\n\nCount of elements: {strList.Count}");

            Console.WriteLine("\nClearing all elements using Clear() method.");
            strList.Clear();
            Console.WriteLine("List count after clearing: " + strList.Count);

            // Re-adding for next steps
            strList.AddRange(new List<string> { "Kiran", "Anu", "Ravi", "Kishore", "Divya" });

            Console.WriteLine("\nUsing Exists to check for 'Kishore': " + strList.Exists(name => name == "Kishore"));

            string found = strList.Find(name => name == "Kishore");
            Console.WriteLine("Using Find to check for 'Kishore': " + (found ?? "Not found"));

            Console.WriteLine("Using Contains to check for 'Kishore': " + strList.Contains("Kishore"));

            Console.WriteLine("\nInserting 'Sneha' at index 2:");
            strList.Insert(2, "Sneha");
            strList.ForEach(s => Console.Write(s + " "));

            Console.WriteLine("\n\nReversing the list:");
            strList.Reverse();
            strList.ForEach(s => Console.Write(s + " "));

            Console.WriteLine("\n\nRemoving element at index 3:");
            if (strList.Count > 3)
            {
                strList.RemoveAt(3);
            }
            strList.ForEach(s => Console.Write(s + " "));

            Console.WriteLine("\n\n===== List of Student Class Objects =====");
            List<Student> studentList = new List<Student>();

            for (int i = 1; i <= 10; i++)
            {
                studentList.Add(new Student(i, "Student" + i));
            }

            // Adding a Kishore Student manually for test
            studentList.Add(new Student(101, "Kishore"));

            Console.WriteLine("\nStudent List:");
            foreach (Student stu in studentList)
            {
                stu.Display();
            }

            Console.WriteLine($"\nTotal Students: {studentList.Count}");

            Console.WriteLine("\n===== Check for Student named 'Kishore' =====");

            // 21. Exists method
            bool existsKishore = studentList.Exists(stu => stu.Name == "Kishore");
            Console.WriteLine("Using Exists: Kishore is " + (existsKishore ? "present" : "not present"));

            // 22. Find method
            Student kishoreFound = studentList.Find(stu => stu.Name == "Kishore");
            Console.WriteLine("Using Find: " + (kishoreFound != null ? $"Found - {kishoreFound.Name}" : "Not found"));

            // 23. Contains method (works because Equals is overridden)
            bool containsKishore = studentList.Contains(new Student(101, "Kishore"));
            Console.WriteLine("Using Contains: Kishore is " + (containsKishore ? "present" : "not present"));

            // 24. Insert student
            Console.WriteLine("\nInserting a new student at index 5:");
            studentList.Insert(5, new Student(500, "InsertedStudent"));
            foreach (Student s in studentList)
                s.Display();

            Console.WriteLine("\nClearing all students from list...");
            studentList.Clear();
            Console.WriteLine("Student list count after clearing: " + studentList.Count);
        }
    }
}
