using System;

// Create a string and reverse it using the ToCharArray() and Reverse() methods
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Combine all of the chars into a new comma-separated-value string using Join()

string[] items = { "first", "second", "third" };
string result = string.Join(", ", items);
Console.WriteLine(result);

// Split a string into an array of strings using Split()
string[] items = result.Split(", ");
foreach (var item in items)
{
    Console.WriteLine(item);
}
