# Branch the Flow of Code Using the switch-case Construct in C\#

Learn how to add branching logic that matches one variable or expression against
many possible values.

## Introduction

The C# programming language is similar to any human written or spoken language.
They each support different ways of expressing the same idea. In spoken
languages, some words and phrases are more descriptive, accurate, or succinct
than others. In the C# programming language, there is more than one way to
create branching logic. For example, selections that use `if` statements and
selections that use `switch` statements. Depending on the context of your
application, one type of selection statement might be more expressive and
succinct than the other.

Suppose working on applications that make extensive use of selections
statements. In some cases, `if-elseif-else` constructs produce the required
result, but are difficult to read and maintain. You have been tasked with
reviewing the code and determining when it is suitable to use a `switch`
statement rather than an `if` statement.

In this module, you'll investigate the use of a `switch` statement to implement
branching logic as an alternative to an if statement. You'll also work on
converting an if-elseif-else construct to a `switch-case` construct. During this
process, you'll learn to recognize the benefits of choosing one type of
selection statement over the other.

By the end of this module, you'll be able to implement `switch` statements in
your application, judge when to use a `switch` statement over an
`if-elseif-else` construct, and convert `if-elseif-else` constructs to `switch`
statements.

### Learning objectives

- Use the switch-case construct to match a variable or expression against
  several possible outcomes.
- Convert code that uses an if-elseif-else construct into a switch-case
  construct.


## Exercise 1: Implement a switch statement

A `switch` statement is a C# selection statement that provides an alternative to
an `if-elseif-else` construct. The `switch` statement is useful when you want to
match a variable or expression against several possible outcomes.

Consider the following scenario:

- You're working on an application related to food nutrition. A section of the
  code deals with fruits.
- Your code includes a variable named fruit that's used to hold the name of
  different types of fruit.
- You have a list of the 20 fruits that your application is focused on.
- You want to branch your code based on the value assigned to fruit.

In this scenario, you can use a `switch` statement to branch your code based on
the value assigned to the fruit variable.

### How does a switch statement work?

The `switch` statement chooses one section of code to execute from a list of
possible switch sections. The selected switch section is chosen based on a
pattern match with the statement's match expression.

Consider the following code sample that shows the basic structure of `switch`
statement:

```csharp
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}
```

The match expression (which may also be referred to as the switch expression) is
the value following the `switch` keyword, in this case `(fruit)`. Each switch
section is defined by a ***case pattern***. Case patterns are constructed using the
keyword `case` followed by a value. The first case pattern in this example is:
`case "apple"`:. Case patterns are Boolean expressions that evaluate to either
`true` or `false`. Each switch section includes a small number of code lines that
will be executed if the case pattern is a match for the match expression. In
this example, if `fruit` is assigned a value of "apple", the first case pattern
will evaluate as `true` and that switch section will be executed.

A switch statement must include at least one switch section, but will normally contain three or more switch sections.

The switch is best used when:

- You have a single value (variable or expression) that you want to match against many possible values.
- For any given match, you need to execute a couple of lines of code at most.

> [!NOTE]
> This first example of a `switch` statement is purposefully simple and your examination of the syntax was brief. You will be examining additional features of the `switch` statement when you work through some more advanced scenarios in the sections below.


### Recap

Here's the main takeaways you learned about the switch statement:

- Use the switch statement when you have one value with many possible matches, each match requiring a branch in your code logic.
- A single switch section containing code logic can be matched using one or more labels defined by the case keyword.
- Use the optional default keyword to create a label and a switch section that will be used when no other case labels match.

### Code

[C#](./Exercises/Exercise1/Program.cs)


## Exercise 2: Complete a challenge activity using switch statements

### Convert to switch statements challenge

In this challenge, you'll rewrite an `if-elseif-else` construct as a `switch` statement. This challenge should help you see the strengths/weaknesses of the `switch` statement when compared to an `if-elseif-else` construct. Good luck.

### Code challenge: rewrite if-elseif-else using a switch statement

You'll start with code that uses an `if-elseif-else` construct to evaluate the components of a product SKU. The SKU (Stock Keeping Unit) is formatted using three coded values: `<product #>-<2-letter color code>-<size code>`. For example, a SKU value of `01-MN-L` corresponds to (sweat-shirt)-(maroon)-(large), and the code outputs a description that appears as "Product: Large Maroon Sweat shirt".

Your challenge is to convert the `if` statement code to a `switch` statement that achieves the same result as the initial code.

### Code

[C#](./Exercises/Exercise2/Program.cs)

## Review the solution to the switch statement challenge activity

The following code sample shows one possible solution to the challenge activity.

```csharp
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
```

This code is merely "one possible solution". No matter what, the output should remain the same:

```text
Product: Large Maroon Sweat shirt
```

## Summary

Your goal was to add branching logic that matches one variable or expression against many possible values.

Using the `switch-case` construct, you matched an employee's numeric level with their title. You used the `switch-case` as a replacement for the `if-elseif-else` construct to more succinctly express your intent of converting a Stock Keeping Unit (SKU) into a long-form description.

C# developers use `if` and `switch` selection statements, along with conditional operators, to branch their code. The experience you've gained using selection statements enables you to choose the best C# tool for expressing your intent in your code.

## Achievement

![](achievement.png)
