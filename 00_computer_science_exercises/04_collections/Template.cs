using System;
using System.Linq;
using System.Collections;


class Collections {
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
  double[] testscores = {0.1,100,27,64,34};
  double[] GPA = {0.16,2.7,9001,6.9,6.3};

  // Print Array Contents -- All elements on Single Lie
  Console.WriteLine("The elements of each array are\n.");
  Console.WriteLine("breakFastFoods: \n" + String.Join(" , ", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen.

    // Print Array Contents -- All elements on Single Lie
  Console.WriteLine("The elements of each array are\n.");
  Console.WriteLine("breakFastFoods: \n" + String.Join("\n", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen.

  // How long is my array? Determining array length
  Console.WriteLine("The length of the breakFastFoods array is: " + breakfastfoods.Length);
  // .Length is known as Property of the array.
  }
}