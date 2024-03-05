# Create C# Methods with Parameters

Learn how to use different types of input parameters in methods


## Introduction

Methods have the ability to perform operations on input. Passing parameters to
your methods allows you to perform the method's task with different input
values. Using method parameters lets you extend your code while keeping your
program organized and readable. If you consider a method to be a black box that
accepts input and performs a single task, you can quickly divide a large problem
into workable pieces.

Suppose you need to write code that performs the same operation on different
sets of input. You might have three different arrays, and need to display the
contents of each one. You can create a `DisplayArray` method that accepts a
single array as input and displays the contents. Instead of writing code to
display each individual array, you can call the same method and provide the
different arrays as input.

Parameters can make your methods more robust while still performing the same
general task. In this module, you'll learn more about working with parameters
and solidify your understanding of methods.

### Learning Objectives

- Learn more about using parameters
- Understand method scope
- Understand pass-by-reference and pass-by-value parameter types
- Learn how to use optional and named arguments

## Exercise 1 - Use parameters in methods

When creating methods, you'll often want to provide some information for the
method to use. Information consumed by a method is called a parameter. You can
supply as many parameters as needed to accomplish its task, or none at all.

The terms 'parameter' and 'argument' are often used interchangeably. However,
'parameter' refers to the variable in the method signature. The 'argument' is
the value passed when the method is called.

### Add parameters to methods

Parameters in a method work similar to variables. A parameter is defined by
specifying the data type followed by the name of the parameter. Parameters are
declared in the method signature, and the values for the parameters are provided
by the method caller instead of being initialized inside the method itself.
Consider the following code:

```csharp
CountTo(5);

	void CountTo(int max)
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"${i}, ");
		}
	}
```

In this example, the method `CountTo` accepts an integer parameter named `max`.
The parameter is referenced in the `for` loop of the method. When `CountTo` is
called, the integer `5` is supplied as an argument.

In this exercise, you'll learn how to create and use your own method parameters.

### Code

[C#](./Exercises/Exercise1/Program.cs)

### Recap

- Information can be passed to methods in the form of parameters.
- Parameters are declared in the method signature.
- Multiple parameters are separated by commas.
- Methods can accept variable or literal arguments.

## Exercise 2 - Understand method scope

`for` loops, `if-else` statements, and methods all represent different types of
code blocks. Each code block has its own 'scope'. 'Scope' is the region of a
program where certain data is accessible. Variables declared inside a method, or
any code block, are only accessible within that region. As programs become more
complicated, this pattern helps programmers consistently use clearly named
variables and maintain easy to read code.

In this exercise, you'll learn more about method scope by working with different
types of methods and variables.

### Test variable scope

Statements declared outside of any code block are called top-level statements.
Variables declared in top-level statements are called 'global variables'. Global
variables aren't restricted to any scope, and can be used anywhere throughout
the program. Global variables can be useful for different methods that need to
access the same data. However, it's important to pay attention to variable names
in different scopes.

### Code

[C#](./Exercises/Exercise2/Program.cs)

### Recap

- Variables declared inside of a method are only accessible to that method.
- Variables declared in top-level statements are accessible throughout the
  program.
- Methods don't have access to variables defined within different methods.
- Methods can call other methods.

## Exercise 3 - Use value and reference type parameters

In C#, variables can be categorized into two main types, value types and
reference types. These types describe how variables store their values.

Value types such as `int`, `bool`, `float`, `double`, and `char` directly
contain values. Reference types such as `string`, `array`, and objects (such as
instances of `Random`) don't store their values directly. Instead, reference
types store an address where their value is being stored.

### Parameters passed by value and passed by reference

When an argument is passed to a method, value type variables have their values
copied into the method. Each variable has its own copy of the value, so the
original variable isn't modified.

With reference types, the address of the value is passed into the method. The
variable given to the method references the value at that address, so operations
on that variable affect the value that is referenced by the other.

> [!NOTE]
> It is important to remember that string is a reference type, but it is
> immutable. That means once it has been assigned a value, it can't be altered.
> In C#, when methods and operators are used to modify a string, the result that
> is returned is actually a new string object.

### Code

[C#](./Exercises/Exercise3/Program.cs)

### Recap

- Variables can be categorized as value types and reference types.
- Value types directly contain values, and reference types store the address of
  the value.
- Methods using value type arguments create their own copy of the values.
- Methods that perform changes on an array parameter affect the original input
  array.
- String is an immutable reference type.
- Methods that perform changes on a string parameter don't affect the original
  string.

## Exercise 4 - Methods with optional parameters

The C Sharp language allows the use of named and optional parameters. These
types of parameters let you select which arguments you want to supply to the
method, so you aren't restricted to the structure defined in the method
signature.

Named arguments allow you to specify the value for a parameter using its name
rather than position. Optional parameters allow you to omit those arguments when
calling the method.

In this exercise, you'll learn how to use both named and optional parameters.

### Code

[C#](./Exercises/Exercise4/Program.cs)

### Recap

- Parameters are made optional by setting a default value in the method
  signature.
- Named arguments are specified with the parameter name, followed by a colon and
  the argument value.
- When combining named and positional arguments, you must use the correct order
  of parameters.

## Exercise 5 - Complete the challenge to display email addresses

### Display email addresses

Your challenge is to create a method that displays the correct email address for
both internal and external employees. You're given lists of internal and
external employee names. An employee's email address consists of their username
and company domain name.

The username format is the first two characters of the employee first name,
followed by their last name. For example, an employee named "Robert Bavin" would
have the username "robavin". The domain for internal employees is "contoso.com".

In this challenge, you're given some starting code. You must decide how to
create and call a method to display email addresses.

### Code

[C#](./Exercises/Exercise5/Program.cs)

### Review

This is one possible solution to the challenge.

```csharp
string[,] corporate =
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external =
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++)
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++)
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com")
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}
```

## Summary

Your goal was to learn more about using parameters in methods and to understand
method scope. You learned about value and reference types and how data is
affected inside of a method. You also learned how to use named and optional
arguments to extend your method's capabilities.
