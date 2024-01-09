// Basic for loop
Console.WriteLine("Basic for loop");
Console.WriteLine("for (int i = 0; i < 10; ++i)");
Console.WriteLine("====================================");
for (int i = 0; i < 10; ++i)
{
    Console.WriteLine(i);
}

// Change the iteration conditions
Console.WriteLine("Change the iteration conditions");
Console.WriteLine("for (int i = 10; i >= 0; --i)");
Console.WriteLine("====================================");
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

// Experiment with the iterator's pattern
Console.WriteLine("Experiment with the iterator's pattern");
Console.WriteLine("for (int i = 0; i < 10; i += 3)");
Console.WriteLine("====================================");
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// Use the break keyword to break the iteration statement
Console.WriteLine("Use the break keyword to break the iteration statement");
Console.WriteLine("for (int i = 0; i < 10; ++i) { if (i == 5) { break; } }");
Console.WriteLine("====================================");
for (int i = 0; i < 10; ++i)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

// Loop through each element of an array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Examine the limitation of the foreach statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    // if (name == "David") name = "Sammy"; // <- Compile error
}

// Overcoming the limitation of the foreach statement using the for statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David") names[i] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name);
