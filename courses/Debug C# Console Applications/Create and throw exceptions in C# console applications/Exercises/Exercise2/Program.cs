/*
All methods must be converted from static string methods to static void methods.
The Process1 method must throw exceptions for each type of issue encountered.
The Workflow1 method must catch and handle the FormatException exceptions.
The top-level statements must catch and handle the DivideByZeroException exceptions.
The Message property of the exception must be used to notify the user of the issue.
*/

string[][] userEnteredValues =
[
            ["1", "2", "3"],
            ["1", "two", "3"],
            ["0", "1", "2"]
];

try
{
    Workflow1(userEnteredValues);
}
catch (Exception e)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(e.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
        }
        catch (FormatException e)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("");
    }

    Console.WriteLine("'Workflow1' completed successfully.");
}

static void Process1(String[] userEntries)
{

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out int valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }

    Console.WriteLine("Process1 completed successfully.");
}

/*
'Process1' completed successfully.

'Process1' encountered an issue, process aborted.
Invalid data. User input values must be valid integers.

An error occurred during 'Workflow1'.
Invalid data. User input values must be non-zero values.
*/
