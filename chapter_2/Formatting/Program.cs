using static System.Console;
using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples =12;
            decimal pricePerApple = 0.35M;
            WriteLine(
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
            WriteLine(formatted);

            // Using interpolated strings

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;

            WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: "Name",
                arg1: "Count"
            );

            WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: applesText,
                arg1: applesCount
            );

            WriteLine(
                format: "{0,-8} {1, 6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );

            // getting text input with ReadLine() method
            Write("\n\nType your firstname and press ENTER: ");
            string firstname = ReadLine();

            Write("Type your age and press ENTER: ");
            int age = Int32.Parse(ReadLine());

            WriteLine(
                format: "Welcome {0} you are {1} years old.",
                arg0: firstname,
                arg1: age-7
            );

            // getting key input
            Write("\nPress any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine(
                format: "Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
        }
    }
}
