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

  
    // String Concatenation "Con-Cat-Uh-Nation"
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);

    // String Concatenation Method #2
    string comboString2 = string.Concat(greeting, goodbye);
    Console.WriteLine(comboString2);

    // String Interpolation -- Subsituting variables into strings.
    string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}\n";
    Console.WriteLine(comboString3);

    // Subsituting Variables into Strings Method 2
    Console.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye + "\n");

    // Accessing Parts of Strings
    // Index is a specific location of a character in a string
    // All strings indexes start at 0
    Console.WriteLine(goodbye[0]); // Print the character at index 0.
    Console.WriteLine(goodbye[4]); // Replace x with what to print the 5th char?
    
    // Where is it in my string?
    Console.WriteLine(greeting.IndexOf("y"));

    // Finding parts of a string
    string fullName = "TF2 Sniper"

    // What Letter?
    int lastInitial = fullname.IndexOf("S");

    // Find the substring.
    string lastname = fullName.Substring(lastInital);

    // Print it.
    Console.WriteLine(lastName);
    
  }
}