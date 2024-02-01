/*
Exercise 3
Define a reference type variable
*/
using System;

// Create a reference type variable named data that can store an array of int values.
int[] data;


data = new int[3];
/*
The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory. The .NET Runtime complies, and returns a memory address of the new int array. Finally, the memory address is stored in the variable data. The int array's elements default to the value 0, because that is the default value of an int.
*/

// Strings are also reference types. Create a reference type variable named message that can store a string value. You don't need to use the new keyword to create a string, because the C# compiler will do that for you.
