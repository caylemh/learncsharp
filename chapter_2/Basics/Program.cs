using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some unused variables using types
            // in additional asemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            
            // Console.WriteLine("Hello World!");

            // Console.WriteLine("Temperature on {0:D} is {1} C.", DateTime.Today, 23.4);

            // loop through the asemblies that this app referemces
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies()) 
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                //declare a variable to count the number of methods
                int methodCount = 0;

                // loop throguh all the types in the assembly
                foreach(var t in a.DefinedTypes) 
                {
                    //add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                //output the count of types and their methods
                Console.WriteLine(
                    "{0:N0} types with {1:N0} methods in {2} assembly.",
                    arg0: a.DefinedTypes.Count(),
                    arg1: methodCount,
                    arg2: r.Name
                );
            }
        }
    }
}
