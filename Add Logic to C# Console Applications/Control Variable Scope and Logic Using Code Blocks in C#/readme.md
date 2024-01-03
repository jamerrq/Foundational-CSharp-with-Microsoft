# Control Variable Scope and Logic Using Code Blocks in C\#

Use code blocks with more confidence, understanding how they impact the
visibility and accessibility of both higher and lower-level constructs in your
code.

## Introduction

Selection and iteration statements use code blocks to group together the code
lines that should be executed, skipped, or iterated over. But that's not the
only purpose for code blocks. Code blocks can also be used to control or limit
variable accessibility and scope. Variable "scope" refers to the parts of your
code where a variable is visible and accessible. Understanding how code blocks
affect variable scope is essential to writing code that is both efficient and
easy to maintain.

Suppose you're working on a large application that uses nested iteration and
selection statements to process array data. Your application uses variables to
help accomplish common tasks application, and you've made some attempt to reuse
the variable names. As your application grows, you start seeing unexpected
results for calculations, and errors that report a variable that is
uninitialized or doesn't exist. You need to improve your understanding of how
code blocks affect variable scope so you can fix the errors and improve the
efficiency of your code.

In this module, you'll declare variables for use inside and outside the
boundaries of code blocks. You'll remove code blocks in certain situations to
make code more readable and efficient. You'll also use code blocks to control
how variables are accessed and used in your code.

### Learning Objectives

- Understand the impact of declaring variables inside and outside of code
  blocks.

- Improve the readability code blocks in `if` statements.


## Exercise 1: Code blocks and variable scope

A code block is one or more C# statements that define an execution path. The
statements outside of a code block affect when, if, and how often that block of
code is executed at run time. The boundaries of a code block are typically
defined by squiggly brackets `{ }`.

In addition to their effect on the execution path, code blocks can also affect
the scope of your variables. The code samples that you examine during this
exercise will help you understand how code blocks affect variable scope.

### Code blocks impact the scope of a variable declaration

Variable ***scope*** refers to a variable's visibility to the other code in your
application. A locally scoped variable is only accessible inside of the code
block in which it's defined. If you attempt to access the variable outside of
the code block, you'll get a compiler error.

The remainder of this unit explores the relationship between code blocks and
variable scope.

### Code

[Exercise 1](./Exercises/Exercise1/Program.cs)


## Exercise 2: Remove code blocks from if statements

Software developers love it when they can write code that saves keystrokes and
visual space without sacrificing readability. Only apply the phrase "less is
more" in the development process when it makes your code more readable and
understandable.

If a code block needs only one line of code, chances are you don't need to
define a formal code block using curly braces. Although technically you don't
even need to separate code into multiple lines, combining statements on a single
line can make your code difficult to read.

Removing the curly braces as described above is a stylistic change that
shouldn't affect the functionality of your code. However, you should take steps
to ensure that your changes do not negatively impact the functionality of your
code. You can evaluate the impact of removing the curly braces and white space,
then revert back to the original code if you find that the changes made your
code less readable.

### Create an example of an if statement that uses a code block

The following code example shows an if statement that uses a code block to
define the execution path. The code block contains a single statement that
displays a message to the console.


```csharp
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
```

Verify that the code compiles and runs as expected.


### Remove the curly braces

The following code example shows the same if statement without the curly braces.

```csharp
bool flag = true;
if (flag)
    Console.WriteLine(flag);
```

Verify that the code compiles and runs as expected. The output should be the
same as the previous example.

### Examine the readability of single-line form if statements

In this step, you're going to look at a case where code readability may be
negatively impacted.

Since both the `if` statement and the method call to `Console.WriteLine()` are
short, you might be tempted to combine them on a single line. After all, C#
syntax for the if statement allows you to combine statements in this way.

```csharp
bool flag = true;
if (flag) Console.WriteLine(flag);
```

Although this code compiles and runs as expected, it's not very readable. The
code is difficult to read because the `if` statement and the method call are
combined on a single line. The code is also difficult to read because the
`Console.WriteLine()` method call is not indented.

To examine the readability impact for larger if-elseif-else constructs, update
your code as follows:


```csharp
string name = "Steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "Steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
```

When you run the code, it produces the following output:

```text
Found Steve
```

The code runs, but these lines of code are dense and hard to read. You may want
to reformat the code to include a line break after the `if`, `else if`, and
`else` statements.

```csharp
string name = "Steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "Steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
```

Notice how much easier it is to read the code when you add line breaks and
indentation.

### Recap

Here are a few important things to remember about `if` statement code blocks and
readability:

- If you realize you have only one line of code listed within the code blocks of
  an if-elseif-else statement, you can remove the curly braces of the code block
  and white space. Microsoft recommends that curly braces be used consistently
  for all of the code blocks of an if-elseif-else statement (either present or
  removed consistently).
- Only remove the curly braces of a code block when it makes the code more
  readable. It's always acceptable to include curly braces.
- Only remove the line feed if it makes the code more readable. Microsoft
  suggests that your code will be more readable when each statement is placed on
  its own code line.

### Code

[Exercise 2](./Exercises/Exercise2/Program.cs)

## Exercise 3: Complete a challenge activity using variable scope

Code challenges will reinforce what you've learned and help you gain some
confidence before continuing on.

### Variable scope challenge

In this challenge, you'll use what you've learned about code blocks and variable
scope to fix the poorly written code sample provided. There are many
improvements that you can make.

### Code challenge: update problematic code in the code editor

The following code example contains a number of issues that you need to fix.
Read through the code and identify the issues. Then, update the code to fix the
issues.

```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
```

### Code

[Exercise 3](./Exercises/Exercise3/Program.cs)

### Review the solution to the variable scope challenge

The following code example shows one possible solution to the challenge.

```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
```

This code is merely "one possible solution" because you may have added line
feeds in different spots, and you may have formatted the code differently.

The biggest changes to the problematic code included:

Moving the declaration of the `total` and `found` variables outside of the
`foreach` statement. Initializing both the `total` and `found` variables with
sensible default values. Removing the code blocks (curly braces) from the `if`
statements. No matter how you formatted the code, when you run the code, you
should see the following output:

```text
Set contains 42
Total: 108
```
If you were successful, congratulations! Continue on to the knowledge check in the next unit.


## Summary

Your goal was to understand how code blocks impact access to variables and the actions required to ensure that variables are appropriately scoped, initialized, and accessible when needed within an application.

You explored the impact of declaring variables inside and outside the boundaries of a code block. You also examined the impact that variable initialization can have on accessibility, as well as how removing unnecessary code blocks can affect code readability.

Code that uses improperly scoped or initialized variables will produce runtime errors. Your ability to scope and initialize variables correctly will ensure a better user experience with your applications.

## Achievement

![](../../imgs/achievements/control_variable_scope_and_logic_using_code_blocks_in_Csharp.png)
