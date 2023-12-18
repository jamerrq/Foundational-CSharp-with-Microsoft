# Create Readable Code with Conventions, Whitespace, and Comments in C\#

## Introduction

The code that you write should communicate your intent to both the compiler and
other developers who may need to read your code. And since you're the developer
who will be reading your code most often, sometimes months after you originally
wrote it, it's in your best interest to write code that's clear and easy to
understand. Remember, you may write code once, but you'll read it many times.

Suppose you've been asked to write some code for another group of developers.
You meet with them to discuss the specification and the assignment is clear.
After the meeting they tell you that you'll be working independently during
development. Once you're done you'll hand off your code to the other group. The
coding task isn't beyond your skill level, but you've never had to write code
that someone else will be maintaining. The team told you that as long as you to
follow the standard coding conventions for C#, there should be no problem. You
make plans to review the C# coding conventions that relate to the code you're
going to work on.

In this module, you'll learn how to choose names for your variables that
describe their purpose and intent. You'll learn how to add code comments that
document the higher-level requirements and your approach in code, as well as to
temporarily instruct the compiler to ignore lines of code. Finally, you'll learn
how whitespace can be used to help convey the relationship of individual lines
of code.

By the end of this module, you'll write code more purposefully, focusing on the
readability and quality of the code to communicate to both the compiler and
other developers.

### Learning objectives

- Choose a descriptive name for variables that describe their purpose and
  intent.

- Use code comments to temporarily instruct the compiler to ignore lines of
  code.

- Use code comments to document the higher-level requirements and your approach
  in code.

- Write code that effectively uses whitespace to convey the relationship of
  individual lines of code.


## Choose variable names that follow rules and conventions

A software developer once famously said, "The hardest part of software
development is naming things." Not only does the name of a variable have to
follow certain syntax rules, it should be also used to make the code more
human-readable and understandable. That's a lot to ask of one line of code!

### Variable name rules

There are some variable naming rules that are enforced by the C# compiler.

- Variable names can contain alphanumeric characters and the underscore
  character (`_`). Special characters like the pound `#`, the dash `-`, and the
  dollar sign `$` are not allowed.

- Variable names must begin with an alphabetical letter or an underscore, not a
  number. Developers use the underscore for a special purpose, so it's best to
  avoid it use for now.

- Variable names must NOT be a C# keyword. For example, these variable name
  declarations won't be allowed: `float float;` or `int int;`.

- Variable names are case-sensitive. For example, `myVariable` and `MyVariable`
  are two different variables.

### Variable name conventions

Conventions are suggestions that are agreed upon by the software development
community. While you're free to decide not to follow these conventions, they're
so popular that it might make it difficult adopting these conventions and make
them part of your own coding habits.

- Variable names should use **camel case**, which is a style of writing that
  uses a lower-case letter at the beginning of the first word and a upper-case
  letter at the beginning of each subsequent word. For example, `string
  thisIsCamelCase;`.

- Variable names should be descriptive. For example, `string name;` is not as
  descriptive as `string firstName;`. You should choose a name for your variable
  that represents its purpose and intent.

- Variable names should be one or more entire words appended together. For
  example, `string firstName;` is better than `string first;` or `string
  first_name;`.

- Variable names shouldn't include type information. For example, `string
  firstName;` is better than `string strFirstName;`.

The example `string firstName;` is a good example of a variable name that
follows the rules and conventions. It's descriptive, uses camel case, and is
composed of one or more entire words.

### Variable name examples

Here are some examples of variable names that follow the rules and conventions.

```csharp
char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;
```

### Other naming conventions

The rules and conventions described above are for local variables. A **local
variable** is a variable that is scoped within the body of a method, or a
variable in a console application that uses top-level statements.

There are other types of constructs that you can use in your applications, and
many have their own conventions. For example, classes are often used in C#
programming. Classes support ***fields***, which are members of a class that act
like variables inasmuch as they store values, or rather state. Classes also
support ***accessibility modifiers***, which allow some values to be private or
public. A private member can only be referenced by other members in the same
class. A public member can be referenced outside of the class. So, you can
create private fields or public fields. Although you won't be creating classes
in this module, it's important for you to know that the naming conventions you
just learned about fit into a larger naming framework.


## Exercise 1 - Create effective code comments

In this exercise, you'll add notes to your code and temporarily disable certain
lines of code from compilation. Then you'll look at how the C# compiler
understands whitespace and how to use whitespace to increase the readability of
your code.

### What is a code comment?

A code comment is a line of text that is ignored by the compiler. It's used to
document the code and to temporarily disable lines of code from compilation.

```csharp
// This is a code comment!
```

This may not seem useful at first, however it's useful in three situations:

- When you want to leave a note about the intent of a passage of code. It can be
  helpful to include code comments that describe the purpose or the thought
  process when you're writing a particularly challenging set of coding
  instructions. Your future self will thank you.

- When you want to temporarily remove code from your application to try a
different approach, but you're not yet convinced your new idea will work. You
can comment out the code, write the new code, and once you're convinced the new
code will work the way you want it to, you can safely delete the old (commented
code).

- Adding a message like TODO to remind you to look at a given passage of code
  later. While you should use this judiciously, it's a useful approach. You may
  be working on another feature when you read a line of code that sparks a
  concern. Rather than ignoring the new concern, you can mark it for
  investigation later.

>[!NOTE] Code comments should be used to say what the code cannot. Often,
> developers update their code but forget to update the code comments. It's best
> to use comments for higher-level ideas and not to add comments about how an
> individual line of code works.

## Exercise 2 - Use whitespace to make your code more readable

Print and web designers understand that putting too much information in a small
space overwhelms the viewer. So, they strategically use whitespace, or negative
space, to break up information to maximize the viewer's ability to consume the
primary message of their work.

Developers can use a similar strategy when writing code in an editor. By using
white space to convey meaning, developers can increase the clarity of their
code's intent.

### What is whitespace?

The term "whitespace" refers to individual spaces produced by the `space bar`,
tabs produced by the `tab` key, and new lines produced by the `enter` key.

The C# compiler ignores whitespace. To understand how whitespace is ignored, and
how to maximize clarity using white space, work through the following exercise.

## Summary

Your goal was to write code that's easy to read and understand.

You used variable naming conventions to improve the readability of your code.
Camel case helps you identify a local variable as opposed to other identifiers
in your code. It also gives you a way to use multiple words that describe the
purpose of a given variable to the reader. You used code comments to temporarily
remove code that you wanted to rewrite before deleting. You also used code
comments to add more meaningful explanations of the code's higher-level purpose
in the system. Finally, you saw how the compiler doesn't care about whitespace
in the code, so you used whitespace judiciously to help improve the readability
of your code.

You learned that you write the code once, but read the code many times.
Improving readability helps you and other developers maintain and support your
code long term.

![](../../imgs/learn.microsoft.com_en-us_training_modules_csharp-readable-code_8-summary(iPad%20Pro).png)
