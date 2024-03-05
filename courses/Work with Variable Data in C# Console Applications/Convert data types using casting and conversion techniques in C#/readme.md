# Convert data types using casting and conversion techniques in C\#

Take control of the data in your applications, knowing when to apply the correct
technique to change data types as needed.

## Introduction

Suppose you're a software developer on a team working on medical intake form
automation. You're tasked with delivery of the application features for
collecting data entered by a medical technician before the doctor sees the
patient. The technician can use the application to record the date and time,
patient age, height, weight, pulse, and blood pressure. The application also
provides text fields for other information, such as the reason for the visit,
current prescriptions, and other items. You work with many data that is in a mix
of data types. For the prototype, you'll build a console application and collect
all of the input as `strings`.

Because the input is initially input as a string, you need to occasionally
change values from one data type into another in the code. A simple example is
any mathematical operation you want to perform with string data. You would first
need to change the value into a numeric data type, like int, and then you could
manipulate the operation. Alternatively, you may want to format and output a
numeric value for a summary report using string interpolation.

You use different techniques to change a data type when necessary. You learn
when to use one technique over another, and when a given technique might risk
the loss of data.

By the end of this module, you're able to take control of the data in your
applications, knowing when to apply the correct technique to change data types
as needed.

### Learning objectives

In this module, you'll:

- Use the casting operator to cast a value into a different data type.
- Use conversion methods to convert a value into a different data type.
- Guard against the loss of data when performing a cast or conversion operation.
- Use the TryParse() method to safely convert a string into a numeric data type.

## Exercise 1 - Explore data type casting and conversion

There are multiple techniques to perform a data type conversion. The technique
you choose depends on your answer to two important questions:

- Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
- Is it possible, depending on the value, that attempting to change the value's
data type would result in a loss of information?

In this exercise, you work your way through these questions, the implications of their answers, and which technique you should use when you need to change the data type.

### Examine the TryParse() method

When working with data, sometimes, you need to convert string data into a
numeric data type. As you learned in the previous unit, because the string data
type can hold a non-numeric value, it's possible that performing a conversion
from a `string` into a numeric data type causes a runtime error.

For example, the following code:

```cs
string name = "Bob";
Console.WriteLine(int.Parse(name));
```
causes the following exception:

```
System.FormatException: 'Input string was not in a correct format.'
```
To avoid a format exception, use the TryParse() method on the target data type.


### Use TryParse()

The `TryParse()` method does several things simultaneously:

- It attempts to parse a string into the given numeric data type.
- If successful, it stores the converted value in an **out parameter**,
  explained in the following section.
- It returns a `bool` to indicate whether the action succeeded or failed.

You can use the Boolean return value to take action on the value (like
performing some calculation), or display a message if the parse operation was
unsuccessful.

### Code

[C#](./Exercises/Exercise1/Program.cs)

### Recap

The `TryParse()` method is a valuable tool. Here are few quick ideas to remember.

- Use `TryParse()` when converting a string into a numeric data type.
- `TryParse()` returns `true` if the conversion is successful, `false` if it's unsuccessful.
- Out parameters provide a secondary means of a method returning a value. In this case, the `out` parameter returns the converted value.
- Use the keyword `out` when passing in an argument to a method that has defined an
out parameter.

## Exercise 2 - Complete a challenge to combine string array values as strings and as integers

### Code

[C#](./Exercises/Exercise2/Program.cs)

## Exercise 3 - Complete a challenge to output math operations as specific number types

### Code

[C#](./Exercises/Exercise3/Program.cs)

## Summary

Your goal was to use several different techniques to change the data type of a given value.

You used implicit conversion, relying on the C# compiler to perform widening conversions. When the compiler was unable to perform an implicit conversion, you used explicit conversions. You used the `ToString()` method to explicitly convert a numeric data type into a `string`.

When you needed to perform `narrowing conversions`, you used several different techniques. You used the casting operator `()` when the conversion could be made safely and were willing to accept truncation of values after the decimal. And you used the `Convert()` method when you wanted to perform a conversion and use common rounding rules when performing a narrowing conversion.

Finally, you used the `TryParse()` methods when the conversion from a `string` to a numeric data type could potentially result in a data type conversion exception.

Without this wealth of options, it would be difficult to work in a typed programming language. Fortunately, this well executed system of types, conversion, and casting can be harnessed to build error free applications.

## Resources

- [Casting and type conversions (C# programming guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- [Built-in types (C# reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)
- [Default values of C# types (C# reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)

## Achievement

![Achievement](achievement.png)
