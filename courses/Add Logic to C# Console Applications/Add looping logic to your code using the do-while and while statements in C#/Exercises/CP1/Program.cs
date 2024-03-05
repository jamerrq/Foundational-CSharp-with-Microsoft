/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
*/

using System;

class Program
{
    static void Main()
    {
        int input = 0;
        bool valid = false;

        Console.WriteLine("Enter an integer between 5 and 10:");
        valid = int.TryParse(Console.ReadLine(), out input);

        while (!valid || input < 5 || input > 10)
        {
            if (!valid)
            {
                Console.WriteLine("You must enter an integer value.");
            }
            else
            {
                Console.WriteLine("You must enter an integer between 5 and 10.");
            }
            Console.WriteLine("Enter an integer between 5 and 10:");
            valid = int.TryParse(Console.ReadLine(), out input);
        }
        Console.WriteLine($"Your input value ({input}) has been accepted.");
    }
}
