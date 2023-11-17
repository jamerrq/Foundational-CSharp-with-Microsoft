/*
Exercise - Print different literal data types
*/

// Use character literals
Console.WriteLine('b');

// Use string literals
Console.WriteLine("Hello, World!");

// Use integer literals
Console.WriteLine(123);

// Use floating-point literals
Console.WriteLine(3.14F); // <- F suffix means float
Console.WriteLine(3.1415); // <- no suffix means double
Console.WriteLine(3.141590m); // <- m suffix means decimal, M also works

// Use boolean literals
Console.WriteLine(true);
Console.WriteLine(false);

/*
Exercise - Setting and getting values from variables
*/

// Variable declaration
string firstName;
// Variable initialization
firstName = "Bob";

// Retrieve the value from the variable
Console.WriteLine(firstName);

// Reassign the variable
firstName = "Alice";
Console.WriteLine(firstName);
firstName = "Eve";
Console.WriteLine(firstName);
firstName = "Mallory";
Console.WriteLine(firstName);

// Variable declaration and initialization (recommended)
string lastName = "Smith";
Console.WriteLine(lastName);
