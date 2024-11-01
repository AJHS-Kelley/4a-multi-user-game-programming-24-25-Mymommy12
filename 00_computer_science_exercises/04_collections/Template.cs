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
  double[] testScores = {0.1,100,27,64,34};
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

  // Acessing elements in the array with the index.
  Console.WriteLine("The first element in breakFastFoods is: " + breakfastfoods[0]);
  // Print the 2nd element of the testScores array.
  // Print the 3rd element of the GPA array.

  // Shortcut to acess last item in an array
  Console.WriteLine("The last element of breakfastfoods is: " + breakfastfoods[breakfastfoods.length - 1]);
  Console.WriteLine("The last element of testScores is " + testScores[testScores.length -1]);

  //Changing elements in the array
  breakfastfoods[2] = "bacon";
  testScores[0] = 100;
  GPA[1] = 2.7;
  Console.WriteLine("The elements of each array are\n.");
  Console.WriteLine("breakFastFoods: \n" + String.Join("\n", breakfastfoods));
  Console.WriteLine(); // Print an empty line to the screen.

// Common errors with arrays
// Console.WriteLine(breakFastFoods[99]); // Index Out of Bounds -- Acessing index that does not exist in the array.

// testScores[0] = "99"; // Error Message "Cannot implicityly convert dataType to DataType"
// Trying to put Incorrect data type into the array.

// Common array methods -- Ways to work with the array data.
// Sorting an array
int[] intArr = {546157614657167871468416476807861674616714067147607168718741671074167, 3, 34424, 16, 12, 34, 17, 832, 6, 3};
string[] zooAnimals = {"Monkey", "Zebra", "Giraffe", "Nigger", "Elephant", "Tiger", "Lion", "Crocodile", "Flamingo"};

Array.Sort (intArr);
Array.Sort (zooAnimals);
// Array.Sort will sort string arrays ALPHABETICALLY

   // Finding the Min, Max, and Sum for numerical arrays.
   Console.WriteLine("The MINIMUM value for the intArr is: " + intArr.MIN());
   Console.WriteLine("The MAXIMUM value for the intArr is: " + intArr.MAX());
   Console.WriteLine("The SUM value for the intArr is: " + intArr.SUM());

  }// Dont Be a dumbass
}// Or a Dumbfuck
/* or a fucking dum
or a dum dum
or a assdumb
or a moron
or a dumbhead
or a retard
or a faggot
or a mindless bozo
or a fucking moron
or a shit head
or a dumb mother fucker
*/