# Choose the correct data type in your C# code

Learn the difference between many data types, how they work, what they do, and how to choose one over another.

## Introduction

The C# programming language relies on data types extensively. Data types restrict the kinds of values that can be stored in a given variable, which can be helpful when trying to create error free code. As a developer, you confidently perform operations on your variables because you know in advance that it only stores valid values.

Suppose your job is to build a new application that must retrieve, manipulate, and store many different kinds of data, including individual numeric values and sequences of numeric and text values. Choosing the right data types is critical to the success of your software development efforts. But what are your options, and what criteria should you use when faced with several data types that seem similar?

In this module, you learn how your application stores and processes data. You learn that there are two kinds of data types that correspond with the two ways that data is processed. You write code that identifies the maximum and minimum values that can be stored in a particular numeric data type. And, you learn the criteria to use when choosing between several numeric data types for your application.

By the end of this module, you'll be confident when working with different data types in C# and able to choose the right data type for your particular application.

### Learning objectives

In this module, you will:

- Learn the fundamental differences between value types and reference types.
- Describe the properties of many new numeric data types, including new integral types and floating point types.
- Write code that returns the maximum and minimum values that numeric data types can store.
- Use the new keyword to create new instances of a reference type.
- Determine which data type you should choose for a given application.

## Discover value types and reference types

With many data types available in C#, choosing the right one to use means that you need to understand when you might choose one data type over another.

Before discussing why you might choose one data type over another, you need to understand more about data types. You also need to know how data and data types work in C# and .NET.

### What is data?

Answering the question "what is data" depends on who you ask, and in what context you're asking it.

In software development, data is essentially a value that is stored in the computer's memory as a series of bits. A bit is a simple binary switch represented as a `0` or `1`, or rather, "off" and "on." A single bit doesn't seem useful, however when you combine 8 bits together in a sequence, they form a byte. When used in a byte, each bit takes on a meaning in the sequence. In fact, you can represent 256 different combinations with just 8 bits if you use a binary (base-2) numeral system.

For example, in a binary numeral system, you can represent the number `195` as `11000011`. The following table helps you visualize how this works. The first row has eight columns that correspond to a position in a byte. Each position represents a different numeric value. The second row can store the value of an individual bit, either `0` or `1`.

| 128 | 64  | 32  | 16  | 8   | 4   | 2   | 1   |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 1   | 1   | 0   | 0   | 0   | 0   | 1   | 1   |

The first column represents the value `128`, the second column represents the value `64`, and so on. The third column represents the value `32`, and the fourth column represents the value `16`. The fifth column represents the value `8`, the sixth column represents the value `4`, the seventh column represents the value `2`, and the eighth column represents the value `1`.

If you add up the number from each column in the first row that corresponds to a 1 in the second row, you get the decimal equivalent to the binary numeral system representation. In this case, it would be `128 + 64 + 2 + 1 = 195`.

To work with larger values beyond `255`, your computer stores more bytes (commonly 32-bit or 64-bit). If you're working with millions of large numbers in a scientific setting, you may need to consider more carefully which data types you're using. Your code could require more memory to run.

### What about textual data?

If a computer only understands `0`s and `1`s, then how does it allow you to work with text? Using a system like ASCII (American Standard Code for Information Interchange), you can use a single byte to represent upper and lowercase letters, numbers, tab, backspace, newline and many mathematical symbols.

For example, if you wanted to store a lower-case letter `a` as a value in my application, the computer would only understand the binary form of that value. To better understand how a lower-case letter `a` is handled by the computer, I need to locate an ASCII table that provides ASCII values and their decimal equivalents. You can search for the terms "ASCII lookup decimal" to locate such a resource online.

In this case, the lower-case letter `a` is equivalent to the decimal value `97`. Then, you would use the same binary numeral system in reverse to find how an ASCII letter `a` is stored by the computer.

| 128 | 64  | 32  | 16  | 8   | 4   | 2   | 1   |
| --- | --- | --- | --- | --- | --- | --- | --- |
| 0   | 1   | 1   | 0   | 0   | 0   | 0   | 1   |

Since `64 + 32 + 1 = 97`, the 8-bit binary ASCII code for `a` is `01100001`.

It's likely that you'll never need to perform these types of conversions on your own, but understanding the computer's perspective of data is a foundational concept, especially as you're considering data types.

### What is a data type?

A data type is a classification of data that tells the compiler or interpreter how the programmer intends to use the data. Most programming languages support basic data types of integer numbers (of varying sizes), floating-point numbers (which approximate real numbers), characters and Booleans. A data type constrains the values that an expression, such as a variable or a function, might take. This data type defines the operations that can be done on the data, the meaning of the data, and the way values of that type can be stored.

For most of the applications you build in your career, you'll settle on a small subset of all the available data types. However, it's still vital to know others exist and why.

### Value vs. reference types

This module focuses on the two kinds of types in C#: reference types and value types.

Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else. In comparison, variables of value types directly contain their data. As you learn more about C#, new details emerge related to the fundamental difference between value and reference types.

#### Simple value types

Simple value types are a set of predefined types provided by C# as keywords. These keywords are aliases (a nickname) for predefined types defined in the .NET Class Library. For example, the C# keyword int is an alias of a value type defined in the .NET Class Library as System.Int32.

Simple value types include many of the data types that you may have used already like char and bool. There are also many integral and floating-point value types to represent a wide range of whole and fractional numbers.

### Recap

- Values are stored as bits, which are simple on / off switches. Combining enough of these switches allows you to store just about any possible value.
- There are two basic categories of data types: value and reference types. The difference is in how and where the values are stored by the computer as your program executes.
- Simple value types use a keyword alias to represent formal names of types in the .NET Library. For example, the C# keyword int is an alias of a value type defined in the .NET Class Library as System.Int32.

## Exercise 1 - Discover integral types

In this exercise, you work with integral types. An **integral type** is a simple value type that represents whole numbers with no fraction (such as `-1`, `0`, `1`, `2`, `3`). The most popular in this category is the `int` data type.

There are two subcategories of integral types: signed and unsigned integral types.

A signed type uses its bytes to represent an equal number of positive and negative numbers. The following exercise gives you exposure to the signed integral types in C#.

```
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807
```

For most non-scientific applications, you likely only need to work with int. Most of the time, you won't need more than a positive to negative 2.14 billion whole numbers.

```
```Output
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615
```

While a given data type can be used for many cases, given the fact that the `byte` data type can represent a value from 0 to 255, it's obvious that this is intended to hold a value that represents a ***byte*** of data. Data stored in files or data transferred across the internet is often in a binary format. When working with data from these external sources, you need to receive data as an array of bytes, then convert them into strings. Many of the methods in the .NET Class Library that deal with encoding and decoding data requires you handle byte arrays.

### Recap

- An integral type is a simple value data type that can hold whole numbers.
- There are signed and unsigned numeric data types. Signed integral types use 1 bit to store whether the value is positive or negative.
- You can use the MaxValue and MinValue properties of numeric data types to evaluate whether a number can fit in a given data type.

### Code

[C#](./Exercises/Exercise1/Program.cs)

## Exercise 2 - Discover floating-point types

In this exercise, you work with floating-point data types to learn about the nuanced differences between each data type.

A floating point is a simple value type that represents numbers to the right of the decimal place. Unlike integral numbers, there are other considerations beyond the maximum and minimum values you can store in a given floating-point type.

### Evaluating floating-point types

First, you must consider the digits of precision each type allows. Precision is the number of value places stored after the decimal point.

Second, you must consider the manner in which the values are stored and the impact on the accuracy of the value. For example, `float` and `double` values are stored internally in a binary (base 2) format, while `decimal` is stored in a decimal (base 10) format. Why does this matter?

Performing math on binary floating-point values can produce results that may surprise you if you're used to decimal (base 10) math. Often, binary floating-point math is an approximation of the real value. Therefore, `float` and `double` are useful because large numbers can be stored using a small memory footprint. However, `float` and `double` should only be used when an approximation is useful. For example, being a few thousandths off when calculating the splatter of a snowball in a video game is close enough.

When you need more a more precise answer, you should use `decimal`. Each value of type `decimal` has a relatively large memory footprint, however performing math operations gives you a more precise result. So, you should use `decimal` when working with financial data or any scenario where you need an accurate result from a calculation.

### Recap

- A floating-point type is a simple value data type that can hold fractional numbers.
- Choosing the right floating-point type for your application requires you to consider more than just the maximum and minimum values that it can hold. You must also consider how many values can be preserved after the decimal, how the numbers are stored, and how their internal storage affects the outcome of math operations.
- Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.
- There's a fundamental difference in how the compiler and runtime handle `decimal` as opposed to `float` or `double`, especially when determining how much accuracy is necessary from math operations.

### Code

[C#](./Exercises/Exercise2/Program.cs)

## Exercise 3 - Discover reference types

Reference types include arrays, classes, and strings. Reference types are treated differently from value types regarding the way values are stored when the application is executing.

In this exercise, you learn how reference types are different from value types, and how to use the `new` operator to associate a variable with a value in the computer's memory.

### How reference types are different from value types

A value type variable stores its values directly in an area of storage called the stack. The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). When the stack frame has finished executing, the values in the stack are removed.

A reference type variable stores its values in a separate memory region called the heap. The heap is a memory area that is shared across many applications running on the operating system at the same time. The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value. The .NET Runtime stores the value, and then returns the memory address to the variable. When your code uses the variable, the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.

You'll next write some code that illustrates these ideas more clearly.

### Code

[C#](./Exercises/Exercise3/Program.cs)

## Choose the right data type

You've been introduced to the difference between value types and reference types, as well as integral and floating point types.

Suppose your job is to build a new application that retrieves, manipulates, and stores different types of data. Which data types do you use?

In some cases, it is an easy choice. For example, when you need to work with text, then you default to using the string data type unless you need to perform a significant amount of concatenation.

But what about working with numeric data? There are 11 different options. How do you choose the right data type?

### Choose the right data type

With so many data types to choose from, what criteria should you use to choose the right data type for the particular situation?

When evaluating your options, you must weigh several important considerations. Often there's no one single correct answer, but some answers are more correct than others.

#### Choose the data type that meets the boundary value range requirements of your application

Your choice of a data type can help to set the boundaries for the size of the data you might store in that particular variable. For example, if you know a particular variable should only store a number between 1 and 10,000 otherwise it's outside of the boundaries of what would be expected, you would likely avoid byte and sbyte since their ranges are too low.

Furthermore, you would likely not need `int`, `long`, `uint`, and `ulong` because they can store more data than is necessary. Likewise, you would probably skip `float`, `double`, and `decimal` if you didn't need fractional values. You might narrow it down to `short` and `ushort`, of which both may be viable. If you're confident that a negative value would have no meaning in your application, you might choose `ushort` (positive unsigned integer, 0 to 65,535). Now, any value assigned to a variable of type `ushort` outside of the boundary of 0 to 65535 would throw an exception, thereby subtly helping you enforce a degree of sanity checking in your application.

#### Start with choosing the data type to fit the data (not to optimize performance)

You may be tempted to choose the data type that uses the fewest bits to store data thinking it improves your application's performance. However, some of the best advice related to application performance (that is, how fast your application runs) is to not "prematurely optimize". You should resist the temptation to guess at the parts of your code, including the selection of data types that may impact your application's performance.

Many assume that because a given data type stores less information it must use less of the computer's processor and memory than a data type that stores more information. Instead, you should choose the right fit for your data, then later you can empirically measure the performance of your application using special software that provides factual insights to the parts of your application that negatively impact performance.

#### Choose data types based on the input and output data types of library functions used

Suppose you want to work with a span of years between two dates. Since the application is a business application, you might determine that you only need a range from about 1960 to 2200. You might think to try to work with `byte` since it can represent numbers between 0 and 255.

However, when you look at the built-in methods on the `System.TimeSpan` and `System.DateTime` classes, you realize they mostly accept values of type `double` and `int`. If you choose `sbyte`, you'll constantly be casting back and forth between `sbyte` and `double` or `int`. In this case, it might make more sense to choose `int` if you don't need subsecond precision, and `double` if you do need subsecond precision.

#### Choose data types based on impact to other systems

Sometimes, you must consider how the information will be consumed by other applications or other systems like a database. For example, SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen before you can save data into that database.

If your application's purpose is to interface with a database, then you would likely need to consider how the data is stored and how much data is stored. The choice of a larger data type might impact the amount (and cost) of the physical storage required to store all the data your application will generate.

#### When in doubt, stick with the basics

While you've looked at several considerations, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:

- `int` for most whole numbers
- `decimal` for numbers representing money
- `bool` for true or false values
- `string` for alphanumeric value

#### Choose specialty complex types for special situations

Don't reinvent data types if one or more data type already exists for a given purpose. The following examples identify where a specific .NET data types can be useful:

- `byte`: working with encoded data that comes from other computer systems or using different character sets.
- `double`: working with geometric or scientific purposes. double is used frequently when building games involving motion.
- `System.DateTime` for a specific date and time value.
- `System.TimeSpan` for a span of years / months / days / hours / minutes / seconds / milliseconds.

### Recap

There are considerations when choosing data types for your code, and often more than one option. Think through your choices, and unless you have a good reason, try to stick with the basic types like `int`, `decimal`, `string`, and `bool`.

## Summary

Choosing the right data type for your application is a vital programming skill. Your goal was to understand the differences between each data type to make an informed decision on the data types in your code.

You've started building a mental model of how data is stored as your application executes. You have experience working with new integral and floating point data types. You have criteria you can use when deciding which data types to employ in your code. Finally, you understand why you need to use the `new` keyword when creating instances of reference types.

## Achievement

![Achievement](achievement.png)
