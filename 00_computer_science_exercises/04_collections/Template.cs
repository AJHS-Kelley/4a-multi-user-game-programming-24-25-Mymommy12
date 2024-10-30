using System;
using System.Linq;
using System.Collections


class 04_Collections {
  static void Main() { // Do Not Delete!

  /*
  In C# an collection is known as an ARRAY.
  -- Each Item in the array is an element
  -- Number of elements in the array cannot be changed.
  -- Contents of each element can change.
  -- Arrays are ordered, Meaning each item has a fixed position.
  -- Position of the element is the index
  -- First element Index is 0.
  */

  // Declaring and defining an array
  string[] breakfastfoods = {"Pancakes","bacon","Scrambled Eggs", "Cereal", "Water"};
  int[] testscores = {"F","F","F","F","F"};
  double[] GPA = {"0.16","2.7","9001","6.9","6.3"};

  // Print Array Contents -- All elements on Single Lie
  Console.WriteLine('The elements of each array are\n.');
  Console.WriteLine("breakFastFoods: \n"= + String.Join(" , ", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen.
  }
}