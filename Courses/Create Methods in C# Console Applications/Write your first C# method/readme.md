# Write your first C# method

Learn to create your own methods to perform specific tasks.

## Introduction

The C# programming language allows you to create your own methods to perform
specific tasks. This is a fundamental concept in programming, and it allows you
to write code that is easier to understand, maintain, and reuse. Suppose you
want to write code to perform operations on unpredictable user input. You might
want to add logic to handle incorrect input, convert input into a workable
format, and perform the correct operation. As your application grows, you might
need to perform these operations in multiple places. By creating a method, you
can write the logic once and call the method from multiple places in your code.

Methods, also called functions, are a key part of keeping code structured,
efficient and readable. A method is a modular unit of code, and a fundamental
programming concept. A method is often designed to perform a specific task and
contains code to execute that task. The name of a method should clearly reflect
its task, which improves code readability and maintainability. Learning how to
use methods will help you build feature-rich applications more quickly.

### Learning Objectives

In this module, you will:

- Create your first C# method
- Identify parts of code that can be modularized into methods
- Use methods to organize code into specific tasks

## Understand the syntax of a method

You might already be familiar with some methods, such as `Console.WriteLine()`
or `random.Next()`. You might have appreciated how these methods simplify tasks
and allow you to build your code more easily.

## How methods work

The process of developing a method begins with creating a method signature. The
method signature declares the method's return type, name and input parameters.
For example, consider the following signature:

```csharp
void SayHello();
```

The method name is `SayHello`. Its return type is `void`, meaning the method
returns no data. However, methods can return a value of any data type, such as
`bool`, `int`, `double`, and arrays as well. Method parameters, if any, should
be included in the parenthesis `()`. Methods can accept multiple parameters of
any data type. In this example, the method has no parameters.

Before you can run a method, you need to add a definition. The method definition
uses brackets `{}` to contain the code that executes when the method is called.
For example:

```csharp
void SayHello()
{
    Console.WriteLine("Hello World!");
}
```

This method definition contains a single line of code that writes `Hello World!`
to the console. When you call the method, the code inside the brackets is
executed.

### Calling a method

A method is called by using its name and including any required arguments.
Consider the following:

```csharp
Console.Write("Input!");
```

The string `"Input!"` is an argument that is passed to the `Write` method. The
`Write` method then writes the string to the console.

A method can be called before or after its definition. For example, the
`SayHello` method can be defined and called using the following syntax:

```csharp
SayHello();

void SayHello()
{
    Console.WriteLine("Hello World!");
}
```

Notice that it isn't necessary to have the method defined before you call it.
This flexibility allows you to organize your code as you see fit. It's common to
define all methods at the end of a program. For example:

```csharp
int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
```

### Method execution

When you call a method, the code in the method body will be executed. This means
execution control is passed from the method caller to the method. Control is
returned to the caller after the method completes its execution. For example,
consider the following code:

```csharp
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello()
{
    Console.WriteLine("Hello World!");
}
```

When you run this code, the output will be:

```plaintext
Before calling a method
Hello World!
After calling a method
```

Once a method is defined, it can be called anytime, as many times as you need to
use it. You can use methods inside of `if-else` statements, for-loops, `switch`
statements, even to initialize variables, and so much more!

### Best practices

When choosing a method name, it's important to keep the name concise and make it
clear what task the method performs. Method names should be Pascal case and
generally shouldn't start with digits. Names for parameters should describe what
kind of information the parameter represents. Consider the following method
signatures:

```csharp
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);
```

The second method describes what kind of data is displayed and provides
descriptive names for parameters.

## Exercise 1 - Create your first method

Typically, a method is created to perform a specific task. In this exercise,
you'll create a method that generates and displays five random numbers.

### Code

[C#](./Exercises/Exercise1/Program.cs)

### Recap

- Create a method by declaring the return type, name, input parameters, and
  method body.
- Method names should clearly reflect the task the method performs.
- Use a method by calling its name and including parentheses ().

## Exercise 2 - Create reusable methods

As you develop applications, you might find yourself writing code to do the same
thing over and over again. Instead of writing duplicate code, using a method to
perform the same task shortens your code and helps you develop applications
faster. In this exercise, you'll identify repeated code and replace it with a
reusable method.

### Code

[C#](./Exercises/Exercise2/Program.cs)

## Exercise 3 - Build code with methods

Methods are useful for organizing code, reusing code, and for tackling problems
efficiently. You can think of a method like a black box that takes input,
performs the named task, and returns output. With this assumption, you can
quickly structure programs just by naming your tasks as methods, and then
filling in the logic after you've identified all of the necessary tasks.

When you use plain language to describe steps in code, without strictly adhering
to syntax rules, you're using "pseudo-code". Combining methods and pseudo-code
is a great way to quickly power through any challenging programming task.

### Code

[C#](./Exercises/Exercise3/Program.cs)

### Recap

- Methods can be used to quickly structure applications
- The `return` keyword can be used to terminate method execution
- Each step of a problem can often be translated into its own method
- Use methods to solve small problems to build up your solution

## Exercise 4 - Complete the challenge to create a reusable method

### Tell a fortune

You're helping to develop a massive multiplayer role-playing game. Each player
has a luck stat that can affect their odds of finding rare treasure. Each day, a
player can speak to an in-game fortune teller that reveals whether their luck
stat is high, low, or neutral.

The game currently has code to generate a player's fortune, but it isn't
reusable. Your task is to create a `tellFortune` method that can be called at
any time, and replace the existing logic with a call to your method.

### Code

[C#](./Exercises/Exercise4/Program.cs)

## Summary

Your goal was to learn how to create your own methods to perform specific tasks.
You learned to move reusable code into methods to minimize repeating code. You
also learned to use pseudo-code and placeholder methods to tackle a complex
problem. By creating small methods with specific responsibilities, you learned
to quickly build solutions for problems using efficient, readable code.

## Achievement

![achievement](achievement.png)
