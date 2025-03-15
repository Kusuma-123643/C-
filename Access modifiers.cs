using System;

namespace AccessModifiersDemo
{
    // 1. Public Access Modifier
    public class Student
    {
        public int StudentId;
        public string StudentName;

        public void DisplayStudent()
        {
            Console.WriteLine("StudentId: " + StudentId);
            Console.WriteLine("StudentName: " + StudentName);
        }
    }

    // 2. Protected Access Modifier
    class ProtectedExample
    {
        protected int x;

        protected void Show()
        {
            Console.WriteLine("Protected value of x: " + x);
        }

        public void SetX(int value)
        {
            x = value;
            Show(); // Accessing protected method inside the class
        }
    }

    // Subclass to access protected members
    class Derived : ProtectedExample
    {
        public void AccessProtected()
        {
            x = 10;
            Show(); // Accessing protected method from base class
        }
    }

    // 3. Private Access Modifier
    class PrivateExample
    {
        private string secret = "This is private data.";

        public void ShowPrivate()
        {
            Console.WriteLine("Accessing private variable: " + secret);
        }
    }

    // 4. Default Access Modifier (internal)
    class DefaultExample
    {
        internal string message = "This is default (internal) access modifier.";
        internal void ShowMessage()
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Public Access Modifier -----");
            Student stu = new Student();
            stu.StudentId = 101;
            stu.StudentName = "Santhi";
            stu.DisplayStudent();

            Console.WriteLine("\n----- Protected Access Modifier -----");
            Derived d = new Derived();
            d.AccessProtected();

            Console.WriteLine("\n----- Private Access Modifier -----");
            PrivateExample p = new PrivateExample();
            p.ShowPrivate();

            Console.WriteLine("\n----- Default Access Modifier (Internal) -----");
            DefaultExample def = new DefaultExample();
            def.ShowMessage();
        }
    }
}
