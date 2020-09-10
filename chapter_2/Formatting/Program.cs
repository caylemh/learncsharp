using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples =12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            // WriteToFile(formatted); // writes the string into a file
            Console.WriteLine(formatted);

            // Using interpolated strings

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            Console.WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            Console.WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            Console.WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            // getting text input
            Console.Write("\n\nType your firstname and press ENTER: ");
            string firstname = Console.ReadLine();

            Console.Write("Type your age and press ENTER: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine(
                format: "Welcome {0} you are {1} years old.",
                arg0: firstname,
                arg1: age-7
            );
        }
    }
}
