/*
Here are the conditions that your second coding project must implement:

- Your solution must include either a do-while or while iteration.

- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

- Inside the iteration block:

    - Your solution must use a Console.ReadLine() statement to obtain input from the user.
    - Your solution must ensure that the value entered matches one of the three role options.
    - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    - Your solution should use the ToLower() method on the input value to ignore case.
    - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

using System;

class Program
{
    static void Main()
    {
        string input = "";
        bool valid = false;

        Console.WriteLine("Enter a role name (Administrator, Manager, or User):");
        input = Console.ReadLine().Trim().ToLower();

        while (!valid)
        {
            if (input == "administrator" || input == "manager" || input == "user")
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("You must enter a valid role name (Administrator, Manager, or User):");
                input = Console.ReadLine().Trim().ToLower();
            }
        }
        Console.WriteLine($"Your input value ({input}) has been accepted.");
    }
}
