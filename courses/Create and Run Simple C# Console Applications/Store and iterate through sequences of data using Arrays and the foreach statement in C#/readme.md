# Store and iterate through sequences of data using Arrays and the foreach statement in C\#

## Introduction

C# arrays allow you to store sequences of values in a single data structure. In
other words, imagine a single variable that can hold many values. Once you have
a single variable that stores all the values, you can sort the values, reverse
the order of the values, loop through each value and inspect it individually,
and so on.

Suppose you work in the security department of a company that matches online
sellers with commission-based advertisers. You've been asked to write C# code
that will iterate through the Order IDs of incoming orders. You need to inspect
each Order ID to identify orders that may be fraudulent. You'll need to
implement arrays to accomplish this programming task.

In this module, you'll create and initialize arrays. You'll set and retrieve
values from elements in an array accessing each element using its index. You'll
create looping logic that allows you to work with each element in an array.

By the end of this module, you'll have worked with your first structure to hold
multiple data values. Later, in other modules, you'll learn how to sort, filter,
query, aggregate, and perform other operations on your data.

## Exercise 1 - Get started with arrays basics

Arrays ca be used to store multiple values of the same type in a single
variable. The values stored in an array are generally related. For example, a
list of student names could be stored in a string array named `studentNames`.

Your work in the security department is focused on finding a pattern for
fraudulent orders. You want your code to review past customer orders and
identify markers associated with fraudulent orders. Your company hopes the
markers can be used to identify potential fraudulent purchase orders in the
future before they are processed. Since you don't always know in advance how
many orders you need to review, you can't create individual variables to hold
each Order ID. How can you create a data structure to hold multiple related
values?

In this exercise, you use arrays to store and analyze a sequence of Order IDs.

### What is an array?

An array is a sequence of individual data elements accessible through a single
variable name. You use a zero-based numeric index to access each element of an
array. As you can see, arrays allow you to collect together similar data that
shares a common purpose or characteristics in a single data structure for easier
processing.

### Declaring arrays and accessing array elements

An array is a special type of variable that can hold multiple values of the same
data type. The declaration syntax is slightly different because you have to
specify both the data type and the size of the array.

[C# Code](./Program.cs)

## Exercise 2 - Implement the foreach statement

Suppose you work for a manufacturing company. The company needs you to complete
an inventory of your warehouse to determine the number of products that are
ready to ship. In addition to the total number of finished products, you need to
report the number of finished products stored in each individual bin in your
warehouse, along with a running total. This running total will be used to create
an audit trail so you can double check your work and identify "shrinkage".

### Looping through an array using foreach

The `foreach` statement provides a simple, clean way to iterate through the
elements of an array. The `foreach` statement processes array elements in
increasing index order, starting with index 0 and ending with index Length - 1.
It uses a temporary variable to hold the value of array element associated with
the current iteration. Each iteration will run the code block that's located
below the `foreach` declaration.

Here's a simple example:

```csharp
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names){
    Console.WriteLine(name);
}
```

Below the `foreach` keyword, the code block that contains the
`Console.WriteLine(name);` will execute once for each element of the `names`
array. As the .NET runtime loops through each element of the array, the values
stored in the current element of the names array is assigned to the temporary
variable `name` for easy access inside of the code block.

If you ran the code, you would see the following output:

```text
Rowena
Robin
Bao
```

Use the `foreach` statement to create a sum of all the items on hand in each bin
of your warehouse.

## Summary

Your goal in this module was to work with a sequence of Order IDs
programmatically. You used arrays to store and access the Order IDs. You used
the `foreach` statement to iterate through the array and inspect each Order ID
individually.

Arrays enabled you to store each Order ID as an element of a single variable.
You addressed a specific element of the array using an index -- a zero-based
numeric value. You were able to retrieve and set the value of each element. You
iterated through the elements of the array to inspect or output each element's
value.

Imagine how difficult it would be to handle related data in your code if you
didn't have a structure like an array? You would need to know ahead of time just
how many data elements you expected to work with and define a separate variable
for each value. That would create a brittle solution.

Arrays can be sized when created according to the amount of data you need to
work with. As you become even more familiar with arrays (and similar data
structures), you'll often use them in your applications to process and manage
data.

![](../../imgs/learn.microsoft.com_en-us_training_modules_csharp-arrays_7-summary(iPad%20Pro).png)
