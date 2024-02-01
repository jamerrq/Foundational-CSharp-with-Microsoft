bool flag = true;
int value = 0; // <- Move the variable outside of the code block
if (flag)
{
    // int value = 10;
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

// Attempt to access the variable outside of the
// code block which it was defined in.
// Console.WriteLine($"Outside of code block: {value}"); // <- Error
// error CS0103: The name 'value' does not exist in the current context

// Move the variable outside
Console.WriteLine($"Outside of code block: {value}");
