# Add Decision Logic to Your Code Using if, else, and else if statements in C#

## Introduction

The C# programming language allows you to build applications that employ decision-making logic.

Suppose you want to display different information to the end user depending on some business rules. For example, what if you want to display a special message on a customer's bill based on their geographic region? What if you want to display a special message to a customer based on their account balance? What if you want to display a special message to a customer based on their account balance and geographic region? Or what if you want to display an employee's title based on their level in the company? In each case, you need to make a decision based on some criteria.

### Learning objectives

In this module, you will:

- Write code that evaluates conditions by using if and else statements.
- Build Boolean expressions by using relational operators.
- Combine multiple Boolean expressions by using logical operators.
- Nest code blocks within other code blocks.

## Exercise - Create decision logic with if statements

Most applications include a large number of execution paths. For example, an application could implement different execution paths based on which menu option a user selects. Developers refer to the code that implements different execution paths as code branches.

The most widely used code branching statement is the `if` statement. The `if` statement relies on a Boolean expression that is enclosed in a set of parentheses. If the expression is true, the code after the `if` statement is executed. If not, the .NET runtime ignores the code and doesn't execute it.

In this exercise you'll practice writing `if` statements by creating a game. First you'll define the rules of the game, then you'll implement them in code.

You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

- If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
- If all three dice you roll result in the same value, you get six bonus points for rolling triples.
- If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

You'll refine the rules as you learn more about the if statement.

> [!NOTE]
> This exercise makes extensive use of the System.Random class. You can refer to the Microsoft Learn module titled "Call methods from the .NET Class Library using C#" if you need a refresher how Random.Next() works.

## Summary

Your goal in this module was to add branching logic to your code by using decision statements.

Using `if`, `else if`, and `else` statements, you evaluated Boolean expressions to create alternative execution paths through your application. This allowed you to execute some code and ignore other code, depending on some condition. Without decision statements, your applications would lack the ability to automate common business, gaming, and scientific tasks required in modern applications.

You'll come to rely on the techniques we learned in this module in virtually every application we build.

![](../../imgs/learn.microsoft.com_en-us_training_modules_csharp-if-elseif-else_7-summary(iPad%20Pro).png)
