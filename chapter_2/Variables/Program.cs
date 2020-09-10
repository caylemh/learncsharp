using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;  // storing a double in an object
            object name = "Amir";  // storing a string in an object

            Console.WriteLine($"\n{name} is {height} metres tall.");

            // int length1 = name.Length;  gives a compile error
            int length2 = ((string)name).Length;  // tell the compiler that its a string
            Console.WriteLine($"{name} has {length2} characters.\n");
        }
    }
}
