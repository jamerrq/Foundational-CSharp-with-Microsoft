# Store and retrieve data using literal and variable values in C\#

Use data in your applications by creating literal values and variable values of
different data types.

## Introduction

Many of the applications that you'll build in C# will require to work with data.
Sometimes that data will be hard-code in your application. Hard-coded values are
values that are constant and unchanged throughout the execution of the program.
For example you may need to print a message to the user when some operations
succeeds. A "success" message would likely be the same every time the
application is executed. This hard-coded value can also be called a constant, or
a literal value.

Suppose you want to display a formatted message to the end user containing
different types of data. The message would include hard-coded strings combined
with information your app collects from the user. To display a formatted
message, you'll need to create both hard-coded values and define variables that
can store data of a certain type, whether numeric, alphanumeric, and so on.

### Learning objectives

- Create literal values for five basic data types
- Declare and initialize variables
- Retrieve and set values in variables
- Allow the compiler to determine the data type for your variable when
  initializing

## Exercise - Print literal values

### What is a literal value?

A literal value is a constant value that never changes. Previously, you
displayed a literal string to the output console. In other words, you literally
wanted that string of alphanumeric characters `H`, `e`, `l`, `l`, `o`, and so on
displayed in the output console.

Use the string data type whenever you have alphanumeric words, phrases, or data
for presentation, not calculation.

### Print different literal data types

There are many data types in C\#. But as you're getting started, you only need
to know about five or six data types since they cover most scenarios. Let's
display a literal instance of data type to output.

### Use character literals

If you only wanted a single alphanumeric character printed to screen, you could
create a char literal by surrounding one alphanumeric character in single
quotes. The term char is short for character. In C#, this data type is
officially named "char", but frequently referred to as a "character".

### Use integer literals

If you want to display a numeric whole number (no fractions) value in the output
console, you can use an int literal. The term `int` is short for integer, which
you may recognize from studying math. In C#, this data type is officially named
"int", but frequently referred to as "integer". An `int` literal requires no
other operations like the `string` or `char`.

### Use floating-point literals

A floating-point number is a number that contains a decimal, for example
3.14159. C# supports three data types to represent decimal numbers: `float`,
`double`, and `decimal`. Each type supports varying degrees of precision.

| Float Type | Precision     |
|------------|---------------|
| float      | ~6-9 digits   |
| double     | ~15-17 digits |
| decimal    | 28-29 digits  |

Here, precision reflects the number of digits past the decimal that are
accurate.

### Use Boolean literals

If you wanted to print a value representing either `true` or `false`, you could
use a **bool literal**.

The term `bool` is short for *Boolean*. In C#, they're officially referred to as
"bool", but often developers use the term "Boolean".

The `bool` literals represent the idea of truth and falsehood. You'll use `bool`
values extensively when you start to add decision logic to your applications.
You'll evaluate expressions to see whether the expression is true or false.

### Why emphasize data types?

Data types play a central role in C#. In fact, the emphasis on data types is one
of the key distinguishing features of C# compared to other languages like
***JavaScript***. The designers of C# believed they can help developers avoid
common software bugs by enforcing data types. You'll see this concept unfold as
you learn more about C#.

### Data types defines capabilities

Earlier, you saw that `string`s and `char`s are used for "presentation, not
calculation". If you need to perform a mathematical operation on numerical
values, you should use an `int` or `decimal`. If you have data that is used for
presentation or text manipulation, you should use a `string` or `char` data
type.

Suppose you need to collect data from a user, like a phone number or postal
code. Depending on the country/region where you live, that data may consist of
numeric characters. However, since you rarely perform mathematical calculations
on phone numbers and postal codes, you should prefer to use a `string` data type
when working with them.

The same can be said of `bool`. If you need to work with the words "true" and
"false" in your application, you would use a `string`. However, if you need to
work with the concept of `true` or `false` when performing an evaluation, you
use a `bool`.

It's important to know that these values may look like their string literal
equivalents. In other words, you may think these statements are the same:

```c#
Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);
```

However, it's only the displayed output that appears to be similar. The fact is
that the kinds of things you can do with the underlying `int` or `bool` will be
different than their `string` equivalent.

### Recap

The main takeaway is that there are many data types, but you'll focus on just a
few for now:

- `string` for words, phrases or any alphanumeric data for presentation, not
calculation
- `char` for a single alphanumeric character
- `int` for a whole number
- `decimal` for a number with a fractional component
- `bool` for a `true`/`false` value

## Declare variables

A literal is *literally* a hard-coded value. Hard-coded values are values that
are constant and unchanged throughout the execution of the program. However,
most applications will require to work with values that you don't know much
about ahead of time. In other words, you'll need to work with data that comes
from users, from files, or from across the network.

When you need to work with data that isn't hard-coded, you'll declare a
variable.

### What is a variable

A **variable** is a container for storing a type of value. Variables are
important because their values can change, or vary, throughout the execution of
a program. Variables can be assigned, read, and changed. You use variables to
store values that you intend to use in your code.

A variable name is a human-friendly label that the compiler assigns to a memory
address. When you want to store or change a value in that memory address, or
whenever you want to retrieve the stored value, you just use the variable name
you created.

### Declare a variable

To create a new variable, you must first declare the data type of the variable,
and then give it a name.

```c#
string firstName;
```

In this case, you're creating a new variable of type `string` called
`firstName`. From now on, this variable can only hold string values.

You can choose any name as long as it adheres to a few C# syntax rules for
naming variables.

### Variable name rules and conventions

A software developer once famously said "The hardest part of software
development is naming things". Not only does the name of a variable have to
follow certain syntax rules, it should also be used to make the code more human
readable and understandable. That's a lot to ask of one line of code!

Here's a few important considerations about variable names:

- Variable names contain alphanumeric characters and the underscore character.
Special characters like the hash symbol `#` (also known as the number symbol or
pound symbol) or dollar symbol `$` are not allowed.
- Variable names must begin with an alphabetic letter or an underscore, not a
  number.
- Variable names are case-sensitive, meaning that `string Value;` and `string
  value;` are two different variables.
- Variable names must not be a C# keyword. For example, you can't name a
  variable `string` or `int` because those are reserved keywords in C#.

There are coding conventions that help keep variables readable and easy to
identify. As you develop larger applications, these coding conventions can help
you keep track of variables among other text.

Here are some coding conventions for variables:

- Variable names should use camel case, which is a style of writing that uses a
lower-case letter at the beginning of the first word and an upper-case letter at
the beginning of each subsequent word. For example, `firstName` and `lastName`.
- Variable names should begin with an alphabetic letter, not a number.
Developers use the underscore for a special purpose, so try to avoid using it
for now.
- Variable names should be descriptive and meaningful in your application.
Choose a name for your variable that represents the kind of data it will hold.
- Variable names should be one or more entire words append together. Don't use
  contractions or abbreviations because the name of the variable (and therefore
  it's purpose) may not be clear to others who are reading your code.
- Variable names shouldn't include the data type. For example, don't name a
variable `stringName` or `intName`. You might see some developers do this, but
this advice is not longer considered a best practice.

The example `string firstName;` follows all of these rules and conventions,
assuming you want to use this variable to store data that represents someone's
first name.

### Variable name examples

Here's a few examples of variable names that follow these rules and conventions:

```c#
char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;
```

### Recap

Here's what you've learned so far about variables:

- Variables are temporary values that you store in the computer's memory and can
  change throughout the execution of a program.
- Before you can use a variable, you have to declare it.
- To declare a variable, you first select a data type for the kind of data you
  want to store, and then give the variable a name that follows the rules.

## Declare implicitly typed local variables

The C# compiler works behind the scenes to assist as you write your code. It can
infer your variable's data type by its initialized value. In this unit, you'll
learn about this feature, called implicitly typed local variables.

### What is an implicitly typed local variable?

An **implicitly typed local variable** is created by using the `var` keyword
followed by a variable initialization. For example:

```c#
var firstName = "Bob";
```

In this example, a string variable was created using the `var` keyword instead
of the `string` keyword.

The `var` keyword tells the C# compiler the data type is implied, the variable
acts the same as if the actual data type was specified. The `var` keyword is
used to save on keystrokes when types are lengthy or when the type is obvious
from the context.

In the example:

```c#
var firstName = "Bob";
```

Because the variable `firstName` is initialized with a string value, the C#
compiler understands the intent and treats every instance of `firstName` as a
`string`.

In fact, the `firstName` variable is typed to be a string and can never be
changed. For example consider the following code:

```c#
var firstName = "Bob";
firstName = 123;
```

If you run this code, you'll see an error message that says:

> (2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'

### Variables using the var keyword must be initialized

It's important to understand that the `var` keyword is dependent on the
initialization value. If you don't initialize the variable, the compiler can't
infer the data type. For example, the following code will not compile:

```c#
var firstName;
```

The compiler will display an error message that says:

> (1,5): error CS0818: Implicitly-typed variables must be initialized

### Why use the var keyword?

The `var` keyword has been widely adopted in the C# community. It's likely that
if you look at a code example in a book or online, you'll see the `var` keyword
used instead of the actual data type name, so it's important to understand its
usage.

The `var` keyword has an important use in C#. Many times, the type of a variable
is obvious from its initialization. In those cases, it's simpler to use the
`var` keyword. The `var` keyword can also be useful when planning the code for
an application. When you begin developing code for a task, you may not
immediately know what data type to use. Using `var` can help you develop your
solution more dynamically.

As you get started, it is recommended that you continue to use the actual data
type name when you declare variables until you become more comfortable working
with code. Using the data type when you declare variables will help you be
purposeful as you write your code.

### Recap

Here's what you've learned so far about implicitly typed local variables:

- The `var` keyword tells the C# compiler the data type is implied from the
  initialization value.
- You'll likely see the `var` keyword as you read other people's code; however,
you should use the data type when possible.
