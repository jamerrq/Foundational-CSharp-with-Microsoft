# Call Methods From the .NET Class Library Using C\#

## Introduction

The C# programming language is supplemented by a large library of functionality
that enables you to create applications, access data in files or on the
Internet, perform advanced mathematical operations, and much more. Understanding
how to navigate this library or functionality is a critical skill that will help
you build feature-rich applications more quickly.

Suppose you need to generate a daily report that's based on thousands of data
files. To save time, your code uses a random sample of the data files to
calculate an approximate result without analyzing all the data files. How can
you generate a random number? Is this supported by C#? If so, how can you write
code to set the value for a random number, and then generate and retrieve the
result?

In this module, you learn about class libraries, and write code that calls
methods in the .NET Class Library. You learn the characteristics of methods, and
why methods of the .NET Class Library are designed and implemented differently
across the .NET Class Library. Most importantly, you write code that uses the
.NET Library methods to achieve a specific programming task. Finally, you'll use
built-in tools and online documentation to help you gather information about the
methods you want to work with.

By the end of this module, you'll know how to find classes and methods in the
.NET Class Library, and how yo use them to perform common programming tasks.

> [!NOTE]
> This module includes coding activities that require Visual Studio
> Code. You'll need access to a development environment that has Visual Studio
> installed and configured for C# application development.

## Get started with .NET Libraries

There's more to building a C# application than stringing together lines of code.
You'll need the .NET Runtime, which hosts and manages your code as it executes
on the end user's computer. You'll also rely on the .NET Class Library, a
prewritten collection of coding resources that you can use in your applications.
This unit explains what the .NET Class Library is and how it complements the C#
programming language.

### What is the .NET Class Library?

When you need to find a book, a public library is a good place to look. After
all, libraries contain thousands and thousands of books, and they're organized
into sections that help you to find what you're looking for. When you need to
implement a programming task, the .NET Class Library is a good place to look,
because it's an organized collection of programming resources.

The .NET Class Library is a collection of thousands of classes containing tens
of thousands of methods. For example, the .NET Class Library includes the
`Console` class for developers working on console applications. The `Console`
class includes methods for input and output operations such as `Write()`,
`WriteLine()`, `Read()`, and `ReadLine()`, and many others. For example, you may
already be familiar with the following code:

```csharp
Console.WriteLine("Hello World!");
```

You can think of a class as a container for methods, kind of like the section of
the public library. Developers typically keep related methods together in a
single class. As you saw in the previous example, any methods that can send or
receive information from a console window are collected into the
`System.Console` class in the .NET Class Library.

In many cases, these classes and methods enable you to build a specific type of
application. For example, one of the larger subset of classes and methods enable
you to create dynamic web applications. There's also several families of classes
that enable you to build native desktop applications. Another subset of classes
and methods enable you to access a database. There are lots of classes in the
.NET Class Library that support specific types of applications.

There are other classes with methods that provide support in a more general way.
In other words, their utility spans a wide range of device platforms,
application frameworks, and technology areas. For example, if you want to read
or write file information, or perform trigonometry or calculus operations, there
are general purpose classes/methods that you can use in your code. It doesn't
matter whether you're building applications for the web, desktop, mobile device,
or the cloud, general purpose classes and methods are there to help.

As you can imagine, having a massive library of functionality available to your
applications is a huge time saver for you as a software developer. The classes
and methods in the .NET Class Library are created by Microsoft and are available
to use in your applications.

#### Even data types are part of the .NET Class Library

C# data types (such as `int`, `string`, `bool`, and `double`) are also part of
the .NET Class Library. The C# language masks the connection between the data
types and the .NET classes in order to simplify your work. However, behind the
scenes, the data types are implemented just like every other class in the .NET
Class Library. this connection provides your everyday variables with built-in
methods that can be very helpful.

### How to find what you need in the .NET Class Library

With so many classes and methods, how can you find what you need for your
application?

First of all, remember that finding every class and method in the .NET Class
Library is like finding every book in a public library. You don't need every
book in the library, and you won't be using every class and method in the .NET
Class Library. Depending on the types of projects that you work on, you'll
become more familiar  with some parts of the .NET Class Library and less
familiar with others. Again, it's like spending time in a section of the public
library, over time you become familiar with what's available. No one knows all
of the .NET Class Library, not even people that work at Microsoft.

Second, necessity will drive you to what you need. Most people go to the library
when they need to find a book, not to see how many different books they can
find. You don't need to research classes and methods without a reason. When you
have trouble figuring out a programming task, you can use your favorite search
engine to find blog posts, articles, or forums where other developers have
worked through similar issues. Third-party sources can give you clues about
which .NET classes and methods you might want to use, and you may even find
sample code that you can try.

Third, Microsoft provides an online language reference and programming guide for
C# that you can search through. You'll likely spend time reading Microsoft's
documentation when you need to understand exactly what methods do, how they
work, and their limitations. This documentation will become your source of truth
for the .NET Class Library. Microsoft's documentation team works closely with
the .NET Class Library's software developers to ensure its accuracy.

Finally, as you begin to experiment with small code projects you'll deepen your
understanding of how the classes and methods work.

All software developers follow a similar process when stepping into unfamiliar
territory. The process of discovery is enjoyable, albeit challenging.

### Recap

- The .NET Class Library supplies you with a wealth of functionality that you
  can use by merely referencing the classes and methods that you need.
- Even your data types are part of the .NET Class Library. C# merely provides an
  alias for those data types.

## Exercise - Call the methods of a .NET Class

### Stateful versus stateless methods

In software development projects, the term state is used to describe the
condition of the execution environment at a specific moment in time. As your
code executes line by line, values are stored in variables. At any moment during
execution, the current state of the application is the collection of all values
stored in memory.

Some methods don't rely on the current state of the application to work
properly. In other words, stateless methods are implemented so that they can
work without referencing or changing any values already stored in memory.
Stateless methods are also known as static methods.

For example, the `Console.WriteLine()` method doesn't rely on any values stored
in memory. It performs its function and finishes without impacting the state of
the application in any way.

Other methods, however, must have access to the state of the application to work
properly. In other words, stateful methods are built in such a way that they
rely on values stored in memory by previous lines of code that have already been
executed. Or they modify the state of the application by updating values or
storing new values in memory. They're also known as instance methods.

Stateful (instance) methods keep track of their state in fields, which are
variables defined on the class. Each new instance of the class gets its own copy
of those fields in which to store state.

A single class can support both stateful and stateless methods. However, when
you need to call stateful methods, you must first create an instance of the
class so that the method can access state.

### Creating an instance of a class

An instance of a class is called an object. To create a new instance of a class,
you use the `new` operator. Consider the following line of code that creates a
new instance of the `Random` class to create a new object called `dice`:

```csharp
Random dice = new Random();
```

The `new` operator does several important things:

- It first requests an address in memory for the new object.
- It creates a new instance of the class at that address.
- It returns the address of the new object, which is stored in the variable
  `dice`.

From that point on, when the `dice` object is referenced in code, the program
knows exactly where to find it in memory.

The latest version of the .NET Runtime enables you to instantiate an object
without having to repeat the type name (target-typed constructor invocation).
For example. the following line of code creates a new instance of the `Random`
class:

```csharp
Random dice = new();
```

The intention is to simplify code readability. You always use parentheses when
writing a target-typed `new` expression.

### Why is the Next() method stateful?

You might be wondering why the `Next()` method was implemented as a stateful
method? Couldn't the .NET Class Library designers figure out a way to generate a
random number without requiring state? And what exactly is being stored or
reference by the `Next()` method?

These are fair questions. At a high level, computers are good at following
specific instructions to create a reliable and repeatable outcome. To create the
illusion of randomness, the developers of the `Next()` method decided to capture
the date and time down to the fraction of a millisecond and use that to seed an
algorithm that produces a different number each time. While not entirely random,
it suffices for most applications. The state that is captured and maintained
through the lifetime of the dice object is the seed value. Each subsequent call
to the `Next()` method is rerunning the algorithm, but ensures that the seed
changes so that the same value isn't (necessarily) returned.

To use the `Random.Next()` method, however, you don't have to understand how it
works. The important thing to know is that some methods require you to create an
instance of a class before you call them, while others do not.

### How can you determine whether you need to create an instance of a class before calling its methods?

One approach for determining whether a method is stateful or stateless is to
consult the documentation. The documentation includes examples that show whether
the method must be called from the object instance or directly from the class.

> [!NOTE]
> You may need to scroll down on the documentation page to find the code
> examples.

As an alternative to searching through product documentation, you can attempt to
access the method directly from the class itself. If it works, you know that
it's a stateless method. The worst that can happen is that you'll get a
compilation error.

### Recap

- To call methods of a class in the .NET Class Library, you use the format
  `ClassName.MethodName()`, where the `.` symbol is the member access operator
  to access a method defined on the class, and the `()` symbols are the method
  invocation operators.
- When calling a stateless method, you don't need to create a new instance of
  its class first.
- When calling a stateful method, you need to create an instance of the class,
  and access the method on the object.
- Use the `new` operator to create a new instance of a class.
- An instance of a class is called an object.

## Exercise - Return values and input parameters of methods

In the previous unit, you used a "roll dice" coding scenario to illustrate the
difference between stateful (instance) and stateless (static) methods. That same
scenario can help you to understand other important concepts about calling
methods. For example:

- handling the return value of a method.
- passing input parameters to a method.
- choosing an overloaded version of a method.

### Return values

Some methods are designed to complete their function and end "quietly". In other
words, they don't return a value when they finish. They are referred to as void
methods.

Other methods are designed to return a value upon completion. The return value
is typically the result of an operation. A return value is the primary way for a
method to communicate back to the code that calls the method.

You saw that the `Random.Next()` method returns an `int` type containing the
value of the randomly generated number. However, a method can be designed to
return any data type, even another class. For example, the `String` class has
some methods that return a string, some that return an integer, and some that
return a Boolean.

When calling a method that returns a value, you'll often assign the return value
to a variable. That way, you can use the value later in your code. In the dice
scenario, you assigned the return value of `Random.Next()` to the `roll`
variable:

```csharp
int roll = dice.Next(1, 7);
```
In some cases, you might want to use the return value directly, without
assigning it to a variable. For example, you might want to print the return
value to the console as follows:

```csharp
Console.WriteLine(dice.Next(1, 7));
```

Even though a method returns a value, it's possible to call the method without
using the return value. For example, you could ignore the return value by
calling the method as follows:

```csharp
dice.Next(1, 7);
```

However, ignoring the return value would be pointless. The reason you're calling
the Next() method is so that you can retrieve the next random value.

### Input parameters

The information consumed by a method is called a parameter. A method can use one
or more parameters to accomplish its task, or none at all.

> [!NOTE]
> Often times, the terms 'parameter' and 'argument' are used
> interchangeably. However, 'parameter' refers to the variable that's being used
> inside the method. An 'argument' is the value that's passed when the method is
> called.

Most methods are designed to accept one or more input parameters. The input
parameters can be used to configure how the method performs its work, or they
might be operated on directly. For example, the Random.Next() method uses input
parameters to configure the upper and lower boundaries of the return value.
However, the Console.WriteLine() uses the input parameter directly by printing
the value to the console.

Methods use a method signature to define the number of input parameters required
and the data type of each parameter.

Consider the use of input parameters in the following code:

```csharp
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
```

This code creates an instance of the `Random` class named `dice`. It then uses
`dice.Next(1, 7)` to assign a random value to an integer named `roll`. In this
case, the `Next()` method accepts two parameters, which are used to configure
the lower and upper boundaries for the new random number. Notice that the
arguments are separated by a `,` symbol. Finally, it uses the
`Console.WriteLine()` method to print the value of `roll` to the console. In
this case, both methods are using input parameters.

Methods define input parameters using a data type. You can't pass arguments of a
different data type as input parameters to the method and expect the method to
work. If you tried, the C# compiler would catch your mistake and force a code
modification before your code will compile and run. Type checking is one way
that C# and .NET uses to prevent end-users from experiencing errors at runtime.

> [!NOTE]
> Although input parameters are often used, not all methods require
> input parameters to complete their task. For example, the Console class
> includes a Console.Clear() method that doesn't use input parameters. Since
> this method is used to clear any information displayed in the console, it
> doesn't need input parameters to complete it's task.

### Overloaded methods

Many methods in the .NET Class Library have overloaded method signatures. Among
other things, this enables you to call the method with or without parameters.

An overloaded method is defined with multiple method signatures. Overloaded
methods provide different ways to call the method or provide different types of
data.

In some cases, overloaded versions of a method are used to accept an input
parameter using different data types. For example, the `Console.WriteLine()`
method has 19 different overloaded versions. Most of those overloads allow the
method to accept different types and then write the specified information to the
console. Consider the following code:

```csharp
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);
```

In this example, you're invoking three separate overloaded versions of the
`WriteLine()` method.

- The first `WriteLine()` method uses a method signature that accepts an `int`
  parameter.
- The second `WriteLine()` method uses a method signature that accepts zero
  input parameters.
- The third `WriteLine()` method uses a method signature that accepts a `string`
  parameter.

In other cases, overloaded versions of a method accept a different number of
input parameters. The alternative input parameters can be used to provide more
control over desired result. For example, the `Random.Next()` method has three
different overloaded versions. The three versions enable you to set various
levels of constraint on the randomly generated number.

## Summary

Your goal was to call methods defined in the .NET Class Library to perform tasks like generating a random number or performing a mathematical operation.

Using C# syntax, you called different kinds of methods in the .NET Class Library: methods that returned values, methods that accepted multiple input parameters, and methods that maintained state. You used Visual Studio Code IntelliSense and learn.microsoft.com to research methods, and to improve your understanding of what a method does and how it works.

Imagine how much effort it would take to develop software if you didn't have a vast library of classes and methods (all of which you didn't have to build personally). The .NET Class Library is a boon to millions of developers. Tens of thousands of businesses rely on applications that are built on top of the methods implemented in the .NET Class Library.

In learning how to harness the .NET Class Library, you've taken a large step towards understanding how software developers build real world applications.

![](../../imgs/learn.microsoft.com_en-us_training_modules_csharp-call-methods_8-summary_source=learn(iPad%20Pro).png)
