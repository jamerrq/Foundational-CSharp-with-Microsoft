/*
* Exercise 3 - Build code with methods
*/

using System;

/*
* Use methods to structure code

Suppose you're a candidate in a coding interview. The interviewer wants you to
write a program that checks whether an IPv4 address is valid or invalid. You're
given the following rules:

- A valid IPv4 address consists of four numbers separated by dots
- Each number must not contain leading zeroes
- Each number must range from 0 to 255 1.1.1.1 and 255.255.255.255 are examples
  of valid IP addresses.

The IPv4 address is provided as a string. You can assume that it only consists
of digits and dots (there are no letters in the string provided).

How would you approach this task?
*/

// Break down the problem into smaller tasks

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
};

void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
