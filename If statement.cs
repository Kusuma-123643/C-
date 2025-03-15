using System;

class AllInOneProgram
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Check if number is Positive or Negative");
        Console.WriteLine("2. Check if Year is Leap Year");
        Console.WriteLine("3. Check if Alphabet is Vowel or Consonant");
        Console.Write("Enter your choice (1/2/3): ");
        
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Positive or Negative
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                    Console.WriteLine($"{num} is a positive number.");
                else if (num < 0)
                    Console.WriteLine($"{num} is a negative number.");
                else
                    Console.WriteLine("The number is zero.");
                break;

            case 2:
                // Leap Year
                Console.Write("Enter a year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    Console.WriteLine($"{year} is a leap year.");
                else
                    Console.WriteLine($"{year} is not a leap year.");
                break;

            case 3:
                // Vowel or Consonant
                Console.Write("Enter any alphabet: ");
                char ch = Convert.ToChar(Console.ReadLine().ToLower());

                if ("aeiou".Contains(ch))
                    Console.WriteLine("The alphabet is a vowel.");
                else if (char.IsLetter(ch))
                    Console.WriteLine("The alphabet is a consonant.");
                else
                    Console.WriteLine("Invalid input. Please enter an alphabet.");
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                break;
        }
    }
}
