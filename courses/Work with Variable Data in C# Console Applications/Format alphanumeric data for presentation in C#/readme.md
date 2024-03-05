# Format alphanumeric data for presentation in C#

Use C# to format strings with white space, special characters, padding, and
alignment. Give context to numeric data like currency, percentages, and numbers
with decimals.

## Introduction

Suppose you work for a sales and marketing department that sends thousands of
personalized letters to the company's existing clients who are institutional
investors. Your team's job is to promote new financial products to the customer.
Each letter you send merges personalized information about the customer. The
letter compares the returns of their current portfolios with projected returns
using the newest products. How will you merge and format the data correctly?

From a high-level perspective, software developers are concerned with:

- ***data input***, including data typed in by a user from a keyboard, using
  their mouse, a device, or by another software system via a network request.
- ***data processing***, including the manipulation of data, such as
  calculations, comparisons, and transformations.
- ***data output***, including the presentation of data to a user, another software system, or a device.

In this module, you will learn how to format alphanumeric data for presentation
in C#. You will learn how to format strings with white space, special
characters,
padding, and alignment. You will also learn how to give context to numeric data
like currency, percentages, and numbers with decimals.

### Learning objectives

In this module, you will:

- Format strings with white space, special characters, padding, and alignment.
- Give context to numeric data like currency, percentages, and numbers with
  decimals.
- Use C# to format strings with white space, special characters, padding, and
  alignment.

## Exercise 1 - Investigate string formatting basics

### Code

[C#](./Exercises/Exercise1/Program.cs)

## Exercise 2 - Explore string interpolation

You need to create the code to print a receipt for the customer purchasing
shares of an investment product. The shares are purchased automatically at the
end of the year based on a series of payroll deductions, so the number of shares
purchased usually contains a decimal amount. To print the receipt, you would
likely need to combine data of different types, including fractional values,
currency, and percentages in precise ways.

### Code

[C#](./Exercises/Exercise2/Program.cs)

## Exercise 3 - Discover padding and alignment

The `string.Format()` method is used to perform composite formatting such as in
the example:

```csharp
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
```

It may have seemed a bit strange that a keyword that represents a data type has
methods you can call in the same way that you call methods on the `Console` class.
The fact is that there are many similar methods on the `string` data type and any
literal string or variable of type string.

Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.

Methods that add blank spaces for formatting purposes (`PadLeft()`, `PadRight()`)
Methods that compare two strings or facilitate comparison (`Trim()`, `TrimStart()`, `TrimEnd()`, `GetHashcode()`, the `Length` property)
Methods that help you determine what's inside of a string, or even retrieve just a part of the string (`Contains()`, `StartsWith()`, `EndsWith()`, `Substring()`)
Methods that change the content of the string by replacing, inserting, or removing parts (`Replace()`, `Insert()`, `Remove()`)
Methods that turn a string into an array of strings or characters (`Split()`,
`ToCharArray()`)

### Code

[C#](./Exercises/Exercise3/Program.cs)

### Recap

There's a few important takeaways from this unit.

- The `string` data type, literal strings, and variables of type string each implement many helper methods to format, modify, and perform other operations on strings.
- The `PadLeft()` and `PadRight()` methods add white space (or optionally, another character) to the total length of a string.
- Use `PadLeft()` to right-align a string.
- Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
- The `+=` operator concatenates a new string on the right to the existing string on
the left.

## Exercise 4 - Complete a challenge to apply string interpolation to a form letter

To the sales and marketing company's newest investment products, you send thousands of personalized letters to the company's existing clients. Your job is to write C# code to merge personalized information about the customer. The letter contains information like their existing portfolio and compares their current returns to projected returns if they were to invest in using the new products.

The writers have decided on the following example marketing message. Here's the
desired output (using fictitious customer account data).

```plaintext
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00
Glorious Future     13.13 %   $63,000,000.00
```

Use your new found knowledge of string formatting to build an application that
can merge and format the appropriate content given the previous example output.
Pay particular attention to the white space and make sure you accurately
represent this exact format using C#.

### Code

[C#](./Exercises/Exercise4/Program.cs)

## Review a solution

Here's a possible solution to the challenge.

```csharp
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
```

## Summary

Your company needed to create a personalized marketing message to promote a new financial product to your customers. Using C#, you were able to write code that combined string and numeric data about your current customers.

You exercised different techniques for merging a string template with variables using composite formatting and string interpolation. The various specifiers allow you to properly format large numbers, currency, and percentages. The built-in methods on variables of type string allowed you to add padding to left and right align data.

Imagine how much extra work would have required if you didn't have a wealth of string and number formatting tools and techniques available to you in C#. You would likely attempt to use string concatenation everywhere, possibly making it difficult to maintain or update.

Techniques and tools for formatting strings and numeric data has a wide array of applications. For example, you can use these techniques to present data for display on screen and format data to transfer between disparate systems.

### Resources

- [String.Format Method](https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0&preserve-view=true)
- [Standard Numeric Format Strings](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)

## Achievement

[![achievement](achievement.png)](https://learn.microsoft.com/api/achievements/share/en-us/JamerJosRebolledoQuiroz-1429/N7CQ6YUF?sharingId=C74FED9E989834A)
