# Guided project - Debug and handle exceptions in a C# console application using Visual Studio Code

This module guides you through a code review and debugging process, as well as
the process for adding exception handling to an application.

## Introduction

C# developers are responsible for code debugging and exception handling in their
applications. The C# language supports exception handling patterns such as the
`try-catch` and `try-catch-finally` patterns. Visual Studio Code uses extensions
to support code debugging. You can find debugger extensions in the Visual Studio
Code Marketplace.

Suppose you're part of a team that's developing retail-support applications. The
team is working on a cash register application that manages retail transactions.
You're developing the `MakeChange` method that manages the money till and
calculates the amount of change returned to the customer. The `MakeChange`
method tracks the number of bills of each denomination (1, 5, 10, and 20) that
are available in the till. The team is planning to add exception handling to the
application during the code verification process.

This module guides you through a code review and debugging process where
exception handling is also added to the application.

By the end of this module, you're able to debug a C# application using the
Visual Studio Code debugger, implement a `try-catch` pattern, and throw
exceptions that are caught at a lower level of the call stack.

### Learning objectives

- Use the Visual Studio Code debugger tools to identify and correct an issue in
  your code logic.
- Implement exception handling in a C# console application using the `try-catch`
  pattern.
- Create and throw exceptions with customized properties.
- Catch exceptions at a lower level in the call stack.


## Prepare

In this guided project, you use Visual Studio Code to update an existing C#
application. Your updates focus on code debugging and adding exception handling
to the application. You review and debug the application, implement a
`try-catch` pattern in top-level statements, and then throw exceptions from
within a method that're caught in the top-level statements.

### Project Overview

You're part of a team that's working on retail-support applications. The code
that you're developing, the MakeChange method, manages the money till for a cash
register application. Your application must meet the following specifications:

- A C# console application that simulates daily purchase transactions.

- The application calls the MakeChange method to manage the money till during
  transactions. MakeChange accepts cash payments and returns change.

- The calling application independently verifies the till balance after each
  transaction.

- A try-catch pattern is implemented to manage exceptions as follows:

    - Exceptions are used to report and handle any issue that prevents a
      transaction from completing successfully.
    - Exceptions are created and thrown in the MakeChange method.
    - Exceptions are caught and handled in the calling application.

An application that simulates transactions and calls the MakeChange method has
already been developed. The Starter code project for this Guided project module
includes a Program.cs file that includes the following code:

- Simulate transactions: the top-level statements configure application data and
  simulate a series of transactions using either a small testData array or a
  larger number of randomly generated transactions.
- Initialize the till: the LoadTillEachMorning method is used to configure the
  cash register till with a predefined number of bills in each denomination.
- Process transactions: the MakeChange method is used to manage the cash till
  during purchase transactions.
- Report till status: the LogTillStatus method is used to display the number of
  bills of each denomination currently in the till.
- Report till balance: the TillAmountSummary method is used display a message
  showing the amount of cash in the till.

> [!NOTE]
> To keep the calculations simple, all item costs are whole numbers and include
> any tax or fee. This keeps the coding tasks focused on debugging and exception
> handling.

Your goal for this module is to verify that the application logic is working
correctly, isolate and correct any logic bugs, and implement exception handling.
To achieve this goal, you'll complete the following exercises:

1. Review and debug the existing application code.
2. Update the application to implement exception handling.


## Exercise 1 - Review and test a C# console application using sample data

In this exercise, you review and test the code in the Starter project, isolate
and fix a logic issue, and then verify that your updated application is working
as expected.

You complete the following tasks during this exercise:

1. Code review: review the contents of the Program.cs file.

    The Program.cs includes the following code sections:

- Top-level statements: the top-level statements simulate a series of
  transactions using either an array of `testData` or a larger number of randomly
  generated transactions.
- LoadTillEachMorning: the `LoadTillEachMorning` method is used to configure the
  cash register till with a predefined number of bills in each denomination.
- MakeChange: the `MakeChange` method is used to manage the cash till during
  purchase transactions.
- LogTillStatus: the `LogTillStatus` method is used to display the number of bills
  of each denomination currently in the till.
- TillAmountSummary: the `TillAmountSummary` method is used display a message
  showing the amount of cash in the till.

2. Initial testing: verify that `MakeChange` successfully balances the money till when using the `testData` array to simulate transactions.

3. Code debugging: isolate and correct a logic issue that's exposed when using randomly generated data.

4. Verification test: perform a verification test on the code you develop in this exercise.


## Exercise 2 - Throw and catch exceptions in a C# console application

In this exercise, you'll develop a `try` code block and catch clause in the
top-level statements, create and throw exceptions in the `MakeChange` method, and
then complete the `catch` code block using an exception object. You complete the
following tasks during this exercise:

1. Update top-level statements: Implement a `try-catch` pattern in the top-level
   statements. The `try` code block will contain the call to `MakeChange`.
2. Update `MakeChange` method: Create and throw exceptions for "Insufficient till"
   and "Underpayment" issues.
3. Update the `catch` code block to use properties of the thrown exception.
4. Verification test: perform verification tests for the code that you develop
   in this exercise.


## Code

[C#](./Guided-project-debugging-CSharp-main/GuidedProject/Starter/Program.cs)

## Summary

Your goal was to gain experience with the Visual Studio Code debugger, implement a `try-catch` pattern, and create and throw exceptions that are caught at a lower level of the call stack.

By reviewing the cash register application, debugging the `MakeChange` method, and implementing exception handling techniques in both the method and calling code, you gained the experience you wanted. You used the debugger tools to configure a breakpoint in the top-level statements of the application. With execution paused, you stepped through the code to isolate an issue in the code logic. You implemented a `try-catch` pattern in the top-level statements, created and threw an `InvalidOperationException` exception in the `MakeChange` method, and then updated the `catch` clause to catch only the `InvalidOperationException` exception type.

The ability to debug C# applications and implement exception handling enables you to develop stable and reliable applications.

## Achievement

![achievement](achievement.png)
