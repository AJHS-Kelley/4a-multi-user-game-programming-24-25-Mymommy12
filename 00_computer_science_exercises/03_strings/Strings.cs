using System;
class Strings {
  static void Main() {
  // In C# ALL STRINGS MUST BE DOUBLE QUOTES "  "

  string greeting = "Sup.\n";
  string goodbye = "See ya.\n";

    // In C# strings are treated like an OBJECT that has properties and methods.
    // PROPERTIES -- things that describe the object such as length, values, data type, ect.
    // METHODS -- built in functions related to that object
    
    // Length is animportant property for strings
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if (greeting.Length > goodbye.Length)
    {
       Console.WriteLine("The greeting has more characters than the goodbye.\n");
    }

    // Useful String Methods
    Console.WriteLine(greeting.ToUpper()); // MAKE THE ENTIRE STRING UPPERCASE
    Console.WriteLine(greeting.ToLower()); // make the entire string lowercase
  }
}