/*
* Exercise 1 Create your first method
*/
using System;
/*
* Create a method to display random numbers

To create a method, first create a method signature and then add the method
body. To create the method signature, you declare the return type, method name,
and parameters. Create the method body by using brackets {} that contain the
code.
*/

// Call your method
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();


// In this case, the method just needs to generate and display information, so
// the return type is void. For now, you don't need to include any parameters.
void DisplayRandomNumbers()
{
    Random random = new Random(); // Here, you create a Random object that is used to generate the numbers.

    // To display five random integers, add a for loop to your method:
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
        // In this code, you generate a number between 1 and 99 (inclusive). You
        // also add a space after the number is printed. Next, you'll display a
        // new line before the method terminates.
    }
    Console.WriteLine();
}
