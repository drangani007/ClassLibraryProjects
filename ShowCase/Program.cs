using System;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " +
                 $"{(StartsWithUpper(input) ? "Yes" : "No")}");
            Console.WriteLine();
            row++;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 0;
        }
    }

    // Define StartsWithUpper method here if not defined in UtilityLibraries
    static bool StartsWithUpper(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        return char.IsUpper(str[0]);
    }
}
