using System;

class StringTasks
{
    static void Main()
    {
        // 1. Reverse a string without using Reverse() function
        Console.WriteLine("1. Enter a string to reverse:");
        string input1 = Console.ReadLine();
        string reversed = "";
        for (int i = input1.Length - 1; i >= 0; i--)
        {
            reversed += input1[i];
        }
        Console.WriteLine("Reversed String is: " + reversed);

        // 2. Find length of a string without using library function
        Console.WriteLine("\n2. Enter a string to find its length (without library function):");
        string input2 = Console.ReadLine();
        int length = 0;
        foreach (char c in input2)
        {
            length++;
        }
        Console.WriteLine("Length of the string: " + length);

        // 3. Calculate length using Count (Length property)
        Console.WriteLine("\n3. Enter a string to calculate its length using Length property:");
        string input3 = Console.ReadLine();
        Console.WriteLine("Length of the string: " + input3.Length);

        // 4. Replace string using Replace() function
        Console.WriteLine("\n4. Replace word in a sentence:");
        string sentence = "Sun Rises in the West";
        string newSentence = sentence.Replace("West", "East");
        Console.WriteLine("Before: " + sentence);
        Console.WriteLine("After: " + newSentence);

        // 5. Convert UPPERCASE to lowercase
        Console.WriteLine("\n5. Enter a UPPERCASE string:");
        string upper = Console.ReadLine();
        Console.WriteLine("Lowercase: " + upper.ToLower());

        // 6. Find maximum occurring character in a string
        Console.WriteLine("\n6. Enter a string to find max occurring character:");
        string input6 = Console.ReadLine().ToLower();
        int max = 0;
        char resultChar = ' ';
        foreach (char c in input6)
        {
            int count = 0;
            foreach (char ch in input6)
            {
                if (c == ch)
                    count++;
            }
            if (count > max)
            {
                max = count;
                resultChar = c;
            }
        }
        Console.WriteLine($"The highest frequency of the character '{resultChar}' appears {max} time(s)");

        // 7. Sort string in ascending order
        Console.WriteLine("\n7. Enter a sentence to sort its characters:");
        string input7 = Console.ReadLine().Replace(" ", ""); // remove spaces
        char[] chars = input7.ToCharArray();
        Array.Sort(chars);
        Console.WriteLine("After sorting: " + new string(chars));

        Console.WriteLine("\nDone!");
    }
}
