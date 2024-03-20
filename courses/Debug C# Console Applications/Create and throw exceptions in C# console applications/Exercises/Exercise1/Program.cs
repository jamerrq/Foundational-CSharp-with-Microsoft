// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        // Prompt the user to enter new bounds
        Console.Write("Enter a new lower bound (or enter Exit to quit): ");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse!.Contains("exit", StringComparison.CurrentCultureIgnoreCase))
        {
            exit = true;

        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
}
while (exit == false);

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{

    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException(nameof(upperBound), "The upper bound must be greater than the lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}
