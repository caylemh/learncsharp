using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whpole numbers
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole numbers
            // including 0
            int integerNumber = -23;

            // flost means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            Console.WriteLine(
                $"\nNatural Number: {naturalNumber}\nInteger Number: {integerNumber}\nReal Number 1: {realNumber}\nReal Number 2: {anotherRealNumber}"
            );

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the three variables have the same value
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}\n");

            // Exploring  number sizes
            Console.WriteLine(
                $"\nint uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} -TO- {int.MaxValue:N0}."
            );
            Console.WriteLine(
                $"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} -TO- {double.MaxValue:N0}."
            );
            Console.WriteLine(
                $"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} -TO- {decimal.MaxValue:N0}.\n"
            );
        }
    }
}
