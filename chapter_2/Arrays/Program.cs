using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an array of string values
            string[] names = new string[4];

            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            // looping through each entry in the array
            foreach(string name in names) {
                Console.WriteLine($"Index {Array.IndexOf(names, name) +1} = {name}");
            }
        }
    }
}
