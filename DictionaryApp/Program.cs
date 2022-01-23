using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringComparer.InvariantCultureIgnoreCase is used so that we can get specific value no mather if key is lower or uper case
            Dictionary<string, Months> months = new Dictionary<string, Months>(StringComparer.InvariantCultureIgnoreCase)
            {    
                {"A",new Months("January")},
                {"B",new Months("February")},
                {"C",new Months("March")},

            };

            // Write keys and values
            foreach (var key in months)
                Console.WriteLine(key);
            Console.WriteLine();

            // Write values for all keys
            foreach (var key in months)
                Console.WriteLine(key.Value);
            Console.WriteLine();

            // Write keys without value
            foreach (var key in months)
                Console.WriteLine(key.Key);
            Console.WriteLine();

            // Write value for given key
            Console.WriteLine(months["b"]);
            Console.ReadLine();
        }
    }
}
