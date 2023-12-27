# Evaluate Boolean expressions to make decisions in C\#

Learn the operators and techniques required to evaluate and compare values in
your decision statements.


## Introduction

Decision logic is based on expressions know as Boolean expressions, that
evaluates to "true" or "false". Developers use various types of operators to
create Boolean expressions that meet their coding requirements. When the
expressions are evaluated, the code execution branches based on the result of
the evaluation. The C# language supports a wide range of operators (such as
equality, comparison and Boolean operators), each of which serves a specific
purpose when implementing decision logic.

Suppose you've been selected to work on a series of C# console applications that
are used to process customer data and user supplied inputs. Each application
requires you to implement decision logic that achieves data processing
requirements and associated business rules. The data processing requirements and
business rules vary for each application. For example, applications that process
customer orders might need to evaluate the status of the customer before taking
any action. To prepare for this upcoming assignment, you'll complete some
practice activities that implement Boolean expressions and C# operators.

In this module, you learn about Boolean expressions, and you use different types
of operators to evaluate expressions for equality, inequality, and comparison.
You also learn to use a special inline version of an `if` statement (a
conditional operator) that produces an "either / or" result.

### Learning objectives

- Use operators to create Boolean expressions that test for comparison and equality.
- Use built-in methods of the string class to perform better evaluations on strings.
- Use the negation operator to test for the opposite of a given condition.
- Use the conditional operator to perform an inline evaluation.


## Exercise 1: Evaluate Boolean expressions

Decision logic is used to establish alternative pathways through your code,
where the decision about which path to follow is based on the evaluation of an
expression. For example, you might write some code that executes one of two
paths based on a user's input. If the user enters the letter "a", your code will
execute one code block. If they enter the letter "b", your code will execute a
different code block. In this example, you're controlling the execution path
based on the value assigned to a string. Your code selects an execution path
based on a expression, how that expression is evaluated, and the underlying
logic used to define the paths.

Examining how to construct and evaluate an expression is a good place to start.

### What is a Boolean expression?

An expression is a combination of values, variables, operators, and method that
return a single value. A statement is a complete instruction in C#, and
statements are comprised of one or more expressions. For example, the following
`if` statement contains a single expression:

```csharp
if (myName == "Luiz")
```

You might have been thinking that the value return by an expression would be a
number or maybe a string. It's true that application developers use different
types of expressions for different purposes. In this case, when you're
developing an `if` selection statement, you'll be using an expression that
return either `true` or `false`. Developers refer to this type of expression as
a Boolean expression. When your code includes a Boolean expression, return value
is always a single `true` or `false` value.

Boolean expressions are important because they're used to control the flow of
your code.

There are many different types of operators that you can use within a Boolean
expression. For example, the `if` statement above uses the equality operator
`==` to check whether a string variable is assigned a particular value. The
operator that you choose will depend on the available code paths, the conditions
associated with the paths, and the underlying application logic.

### Evaluating equality and inequality

One of the most common code evaluations is a check to see whether two values are
equal. When checking for equality, you'll locate the equality operator `==`
between two values being checked. If the values on either side of the operator
are equivalent, then the expression will return `true`. Otherwise, it will
return `false`.

Conversely, you might also need to check whether two values are not equal. To
check for inequality, you'll use the operator `!=` between two values.

You might wonder why you need bot equality and inequality operators. The reason
will become clearer as you learn how to create branching statements and begin to
write real world code. Two operators that perform opposite tasks allow you to be
more expressive and compact.

Now it's time to prepare your coding environment and begin writing code that
evaluates Boolean expressions.

### Improve the check for string equality using the string's built-in helper methods

You might be surprised that the line `Console.WriteLine("a" == "A");` outputs `false`. When comparing strings, case matters.

Also, consider this line of code:

```csharp
Console.WriteLine("a" == "a ");
```

Here you've added a space character at the end of the string. This expression
will also output `false`.

In some cases, having a space character before or after the text might be
perfectly acceptable. However, if you need to accept a match that isn't exact,
you can "massage" the data first. "Massaging" the data means that you perform
some cleanup before you perform a comparison for equality.

For example, consider the case when you're collecting user input inside a loop.
After each value is entered, you could provide the user with a prompt to
determine if they want to continue, such as `Do you want to continue (Y/N)?`. If
the user wants to continue, they will probably enter either `y` or `Y`. You'll want
your code to interpret both values equally, even though `y` isn't equivalent to `Y`.

Before you check two strings values for equality, especially when one or both
values were entered by a user, you should:

- Make sure both strings are all upper-case or all lower-case using the `ToUpper()` or `ToLower()` methods.
- Remove any leading or trailing spaces using the `Trim()` method.

You can improve the previous equality check by chaining these methods together
on both values, as shown in the following code listing:

```csharp
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());
```

### Methods that return a Boolean value

Some methods return a Boolean value (`true` or `false`). In the following exercise,
you'll use a built-in method of the `String` class to determine whether or not a
larger string contains a specific word or phrase that's significant to your
application.

> [!NOTE]
> Some data types have methods that perform helpful utility tasks. The `String` data type has many of these. Several return a Boolean value including `Contains()`, `StartsWith()`, and `EndsWith()`. You can learn more about them in the Microsoft Learn module "Manipulate alphanumeric data using String class methods in C#".

### What is a logical negation?

The term "Logical Negation" refers to the unary negation operator `!`. Some people call this operator the "not operator". When you place the `!` operator before a conditional expression (or any code that's evaluated to either `true` or `false`), it forces your code to reverse its evaluation of the operand. When logical negation is applied, the evaluation produces `true` , if the operand evaluates to `false` , and `false` , if the operand evaluates to `true`.

Here is an example that might help you to see the connection between these
ideas. The following two lines of code produce the same result. The second line
is more compact.

```csharp
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
```

### Inequality operator versus logical negation

The inequality operator `!=` includes a `!` character, but should not be confused with logical negation. The inequality operator returns `true` if its operands aren't equal, and returns `false` if the operands are equal. For the operands of the built-in types, the expression `x != y` produces the same result as the expression `!(x == y)` (an example of logical negation).

The following code sample demonstrates the use of the `!=` operator:

```csharp
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
```

### Recap

Here's the main takeaways you learned about evaluating Boolean expressions so far:

- There are many different kinds of expressions that evaluate to either `true` or `false`.
- Evaluate equality using the `==` operator.
- Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the `ToLower()` or `ToUpper()` helper methods, and the `Trim()` helper method to improve the likelihood that two strings are equal.
- Evaluate inequality using the `!=` operator.
- Evaluate greater than, less than and similar operations using comparison operators like `>`, `<`, `>=`, and `<=`.
- If a method returns a bool, it can be used as a Boolean expression.
- Use the logical negation operator `!` to evaluate the opposite of a given
expression.

[Exercise #1](./Exercises/Exercise1/Program.cs)

## Exercise 2: Implement the conditional operator

Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. The details for the promotion indicate that when a purchase value is greater than $1000, the purchase is eligible for a $100 discount. If the purchase amount is $1000 or less, the purchase is eligible for a $50 discount.

While you could certainly use the `if ... elseif ... else` branching construct to
express this business rule, using the conditional operator to evaluate
eligibility for the promotional discount might be a better choice. The
conditional operator uses a compact format that saves a few lines of code and
possibly makes the intent of the code clearer.

### What is the conditional operator?

The conditional operator `?:` evaluates a Boolean expression and returns one of
two results depending on whether the Boolean expression evaluates to true or
false. The conditional operator is commonly referred to as the ternary
conditional operator.

Here's the syntax for the conditional operator:

```csharp
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```

Take a minute to consider how you'd apply the conditional operator to the
promotional discount scenario. Your goal is to display a message to the customer
that shows their discount percentage. The amount of their discount will be based
on whether they've spent more than $1000 on their purchase.

[Exercise #2](./Exercises/Exercise2/Program.cs)

## Exercise 3: Complete a challenge activity using conditional operators

Code challenges will reinforce what you've learned and help you gain some
confidence before continuing on.

### Conditional operator challenge

In this challenge, you'll implement a conditional operator to simulate a "coin
flip". The resulting decision logic will display either `heads` or `tails`.

### Code challenge: write code to display the result of a coin flip

Here are your challenge requirements:

- Use the `Random` class to generate a value.

- Based on the value generated, display either `heads` or `tails`.
  There should be an equal chance of either value being displayed.

- Your code should be easy to read and understand.
  You should be able to accomplish the desired result in three lines of code.


[Exercise #3](./Exercises/Exercise3/Program.cs)

## Exercise 4: Complete a challenge activity using Boolean expressions

Code challenges will reinforce what you've learned and help you gain some confidence before continuing on.

### Decision logic challenge

In this challenge, you'll implement decision logic based on a series of business
rules. The business rules specify the access that will be granted to users based
on their role-based permissions and their career level. Code branches will
display a different message to the user depending on their permissions and
level.

[Exercise #4](./Exercises/Exercise4/Program.cs)

## Summary

Your goal was to develop decision statements for various situations by using Boolean expressions and C# operators.

Using various operators and techniques, you wrote code that evaluated equality, compared values to see if one was greater or less than (or equal to) the other. You compared strings, massaging them to create a more accurate comparison that eliminated issues like casing and spaces that might interfere with the result you were hoping for. You learned how to use logical negation to flip a value for comparison, and used the result of methods in your Boolean expressions. Finally, you used the conditional operator to succinctly evaluate a condition and return a result.

Without this full complement of operators and techniques, you would be limited
in the kinds of decision statements you could build. Since all business logic
requires some Boolean expressions, you've added a valuable tool to your
programming toolbox.

## Achievement

![](achievement.png)
