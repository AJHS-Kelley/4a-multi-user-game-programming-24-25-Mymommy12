// Data Types and Operators, Kenedy Davis, V0.0
using System;
class DataTypesOperators {
  static void Main() {
   // This is a comment, It gets ignored. (Like me asking a girl out)
    /*
    THis is also a comment.


     */
  }
}
//DATA TYPES
// C# is STATICALLY TYPED -- once a variable has a data type, it cannot be changed

// Float - float -- decimal numbers, +/- including 0.0

// Double - double -- decimal numbers, +/- including 0.0 <-- MOST COMMNLY USED DECIMAL

// Integers -- int -- whole numbers, +/-, including 0

// VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSISDE
// DECLARING (CREATING VARIABLES)
// Method #1 -- Declared But Not Assign
// dataType variableName;

int myInteger;
double myDouble;

// Method #2 -- Declare AND Assign
int myInteger2 =1;
double myDouble2 = 2.05D;

//Strings -- Collections of letters, numbers, special characters.
string myString ="This is my string.";

// Boolean -- bool - True or False value
bool myBool = true;
bool fireResistance = true;
bool hasPurpleKey = false;

// Character -- char - a single character.
char myChar = 'A';

// ASSIFNING VALUES AFTER DECLARATION

myInteger = 5;
myDouble = -1.0D;

// // PRINTING VARIABLES TO THE CONSOLE TERMINAL
// Console.WriteLine(myInteger - 25);
// Console.WriteLine(myDouble + 2.0D);

// OPERATORS -- ARITHMETIC
// Addition
int myNetInt = myInteger + myIntegher2;
double myNewDouble = myDouble + myDouble2;
double myNewNumber = myInteger + myDOuble;

// Subtraction
myNewNumber = myDouble - myInteger;
// Division
myNewNumber = myDouble / myInteger;
// Multiplication
myNewNumber = myDouble * myInteger;

// Modulus -- Divides, then returns the remainder
// Most commonly used to determine Even or Odd
myNewNumber = myDouble % 2;

int students = 6;
int numSlices = 36;
int LeftOvers;

leftovers = numSlices % students;

// Increment / Decrement -- Most frequently used in LOOPS
int x = 0;
x++; // What is x equal to now?
//Increment ++ adds 1 to the current value and puts the new value into the bucket
x--; 
// Decrement -- subtracts 1 from the current value and puts the new value into the bucket
x +=1;
x *=1;
x /=1;
x -=1;
x %=1;
// Take current value, preform the calculation, put new value into bucket

// Comparison Operators
// Evaluate the Expression, Return true or false
int y = 5;
int z = 3;

// IS-Equal-to == is the Value on the left equal to the right
// Console.WriteLine(y == z);

// // Not-Equal-To != is the value on the left not equal to the right?
// Console.WriteLine(y !=z);

// //Greater Than >
// Console.WriteLine (y >z);

// //Less Than <
// Console.WriteLine (y <z);

// //Less Than-Or-Equal-TO
// Console.WriteLine (y <=z);

// //Greater Than-Or-Equal-To >=
// Console.WriteLine (y >=z);

//Logical Operators
int b = 1;
double c = 2.0D;
string favColor = "Blue";

// // Logical AND && -- all statements must be true
// Console.WriteLine(b > 1 && c !=5.0D);    // false because b is not > 1
// Console.WriteLine(b == 1 && c < 10.D);   // both are true, whole expression is true
// // If one expression most likely to be False, check for it First!
// Console.WriteLine(hasPurpleKey == true && playerLevel >5);
// Console.WriteLine(hasPurpleKey == true && playerlevel > 5 && has FlameThrower == true && timeRemaining > 99);

// // Logical Or || -- One Statement must be true
// Console.WriteLine(b > 1 || c !=5.0D); // true bc c is not equal to 5.0
// Console.WriteLine(b == 2 || c < 10.D); // false bc both expresions are false
// // Check for the statement most likely to be true first!
// Console.WriteLine(hasBlueKey == true && playerLevel > 3);

// // Logical Not ! -- Returns the opposite value of the expression.
Console.WriteLine(b > -1);
COnsole.WriteLine (!(b> -1)); //False

//  Reading User Input from the Console / Terminal
Console.WriteLine("What is your player name?  Type it and press ENTER.\n");

//  Create a variable to store the data
string playerName = Console.ReadLine();
//ConsoleReadLine() Only Returns string data types
Console.WriteLine("What is your age? Type it and press ENTER");
string age = Console.ReadLine();
// Adding string data  types together is called Concatenation
// Print the variable to the screen
//Console.WriteLine("Your player name is" + playerName);

// Inputting Numbers from the console.
Console.WriteLine("How many chicken nuggies can you eat in 5 minutes? Enter an integer value and press enter.\n");
int numNuggies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numNiggies- + numNuggies);

  }
}