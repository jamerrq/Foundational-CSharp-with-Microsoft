/*
* Exercise 2 - Create reusable methods

As you develop applications, you might find yourself writing code to do the same
thing over and over again. Instead of writing duplicate code, using a method to
perform the same task shortens your code and helps you develop applications
faster. In this exercise, you'll identify repeated code and replace it with a
reusable method. Let's get started!
*/

/**
* Identify duplicated code

In this task, you'll take a look at an application that tracks medication times
across different time zones. The user enters their current time zone and their
destination time zone. Their medication schedule is displayed and then adjusted
for the new time zone.
*/
using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

/*
Notice that there's several for-loops that are repeated with identical code.

There are two foreach loops that format and display the medicine times. There
are another two for loops that adjust the times according to the time zone
difference.

As you write code, you might find yourself repeating blocks of code to do the
same task. That's a perfect opportunity to consolidate your code by using a
method to perform the task instead.
*/

void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes()
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
