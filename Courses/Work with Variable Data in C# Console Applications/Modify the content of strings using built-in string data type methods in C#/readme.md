# Modify the content of strings using built-in string data type methods in C\#

Use built in methods to extract, remove, or replace data in strings.

## Introduction

Suppose you're a developer for an application letting a business update its
"last chance deals" website by sending an email. The update email uses special
required text in the title and body of the email to instruct the automation how
to update the website. The mail includes next deal title, discount %,
expiration, and when to publish the offer live.

Frequently, application data you need to work with is from other software
systems, and has data you don't want or need. Sometimes the data is in an
unusable format, containing extra information that makes the important
information difficult to extract. To adjust data for your application, you need
tools and techniques to parse through string data, isolate the information you
need, and remove the information you don't need.

In this module, you use string helper methods to identify and isolate the
information you're interested in. You learn how to copy a smaller portion of a
larger string. You replace characters, or remove characters from a string.

By the end of this module, you're able to modify a string's contents, isolating
specific portions to extract, replace, or remove.

### Learning Objectives

In this module, you will:

- Identify the position of a character or string inside of another string
- Extract portions of strings
- Remove portions of strings
- Replace values in strings with different values


## Exercise 1 - Use the string's `IndexOf` and `Substring` methods to extract data

In this exercise, you use the `IndexOf()` method to locate the position of one
or more characters string inside a larger string. You use the `Substring()`
method to return the part of the larger string that follows the character
positions you specify.

You'll also use an overloaded version of the `Substring()` method to set the
length of characters to return after a specified position in a string.

### Code

[C#](./Exercises/Exercise1/Program.cs)

### Recap

This unit covered much material. Here's the most important things to remember:

- `IndexOf()` gives you the first position of a character or string inside of
  another string.
- `IndexOf()` returns `-1` if it can't find a match.
- `Substring()` returns just the specified portion of a string, using a starting
  position and optional length.
- There's often more than one way to solve a problem. You used two separate
  techniques to find all instances of a given character or string.
- Avoid hardcoded magic values. Instead, define a `const` variable. A constant
  variable's value can't be changed after initialization.

## Exercise 2 - Use the string's `IndexOfAny()` and `LastIndexOf()` helper methods

In this exercise, you use the `IndexOfAny()` method to find the first location
of any of the `string` from selected array. You also use `LastIndexOf()` to find
the final location of a string within another string.

### Code

[C#](./Exercises/Exercise2/Program.cs)

### Recap

Here are two important things to remember:

- `LastIndexOf()` returns the last position of a character or string inside of
  another string.
- `IndexOfAny()` returns the first position of an array of char that occurs
  inside of another string.

## Exercise 3 - Use the string's `Replace()` and `Remove()` helper methods

In this exercise, you remove characters from a string using the `Remove()`
method and replace characters using the `Replace()` method.

Sometimes, you need to modify the contents of a string, removing or replacing
characters. While you could replace characters with the tools you already know,
it requires a bit of temporarily storing and stitching strings back together.
Fortunately, the `string` data type has other built-in methods, `Remove()` and
`Replace()`, for these specialized scenarios.

### Code

[C#](./Exercises/Exercise3/Program.cs)

### Recap

Here are two important things to remember:

- The `Remove()` method works like the `Substring()` method, except that it
  deletes the specified characters in the string.
- The `Replace()` method swaps all instances of a string with a new string.

## Exercise 4 - Complete a challenge to extract, replace, and remove data from an input string

### Code

[C#](./Exercises/Exercise4/Program.cs)

### Review a solution

The following code is a possible solution to the challenge.

```csharp
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
```

## Summary

Your goal was to extract, remove, and replace values in strings. Often, the data
you receive has extraneous data or characters that you need to avoid or
eliminate before you can use the target data.

Utilizing the `IndexOf()` method, enabled you to identify the position of a
character or string within another string. The position returned from the
`IndexOf()` method was the first building block to using the `Substring()` method to
extract a portion of a string given the starting position and the number of
characters to extract (the length). It also enabled you to use the `Remove()`
method to eliminate characters from a string given the starting position and the
length. You learned of variations like `LastIndexOf()` method to find the last
position of a character of string within another string, and the `IndexOfAny()` to
find the position of any value of a given char array. You used the `while`
statement to iterate through a longer string to find and extract all instances
of a character or string within a larger source string. Finally, you used the
`Replace()` method to swap all instances of a character or string inside of a
larger string.

While it might be possible to perform these kinds of operations using a `char`
array, iterating through each `char` to find matches, keeping track of the
starting and ending points you wanted to locate, and so on. It would take many
more steps to accomplish what these string helper methods can accomplish in a
single call.

## Achievement

![achievement](achievement.png)
