// Use the equality operator

Console.WriteLine("a" == "a"); // True
Console.WriteLine("a" == "A"); // False
Console.WriteLine(1 == 2);     // False

string myValue = "a";
Console.WriteLine(myValue == "a"); // True

// Improve the code with the equality operator
string value1 = " a"; // Note the leading space
string value2 = "A "; // Note the trailing space
Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());

// Use the inequality operator
Console.WriteLine("a" != "a"); // False
Console.WriteLine("a" != "A"); // True
Console.WriteLine(1 != 2);     // True

string myValue = "a";
Console.WriteLine(myValue != "a");

// Use the Comparison operators
Console.WriteLine(1 > 2);  // False
Console.WriteLine(1 < 2);  // True
Console.WriteLine(1 >= 1); // True
Console.WriteLine(1 <= 1); // True

// Use a method that returns a boolean value
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // True
Console.WriteLine(pangram.Contains("cow")); // False

// Use the Logical Negation operator
Console.WriteLine(!pangram.Contains("fox")); // False
Console.WriteLine(!pangram.Contains("cow")); // True
