using System;
using System.Linq;
using System.Collections.Generic;

namespace PlaceNames
{
    // We write C# code in classes.
    class Program
    {
        // All C# applications start in the "Main" method.
        static void Main(string[] args)
        {
            // We must specify the Type of the "names" variable.
            //  It is a "List" that can only contain "strings".
            List<string> names = new List<string> {
                "Nashville", "Hong Kong", "The back yard", "Earth",
                "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
            };

            // Print some output to the terminal (aka. "Console");
            Console.WriteLine("All Place Names");

            // Iterate over each "name" in the "names" list
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // Filter the list to create a new list that only has 
            //  place names that start with the word "The".
            List<string> theNames = names.Where(n => n.StartsWith("The")).ToList();

            Console.WriteLine("'The' Place Names");
            foreach (var name in theNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
