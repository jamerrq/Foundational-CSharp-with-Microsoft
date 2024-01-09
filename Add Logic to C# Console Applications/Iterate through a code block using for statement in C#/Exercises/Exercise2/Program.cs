for (int i = 0; i < 100; ++i)
{
    if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
    {
        Console.WriteLine($"{i + 1} - FizzBuzz");
    }
    else if ((i + 1) % 3 == 0)
    {
        Console.WriteLine($"{i + 1} - Fizz");
    }
    else if ((i + 1) % 5 == 0)
    {
        Console.WriteLine($"{i + 1} - Buzz");
    }
    else
    {
        Console.WriteLine(i + 1);
    }
}
