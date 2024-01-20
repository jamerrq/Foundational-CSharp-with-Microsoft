# Add looping logic to your code using the do-while and while statements in C\#

Use the do-while and while statements to iterate as long as a Boolean expression
evaluates to true.

## Introduction

As we've said several times in previous modules featuring iteration and decision
statements, there are several techniques you can use to accomplish similar
results. Just like written and spoken languages, in programming languages you
can express the same idea in different ways. Even so, each expression may have a
nuanced difference in meaning.

The `do-while` and `while` statements are allow us to control the flow code
execution by looping through a block of code until a condition is met. When
working with the `foreach` statement, we iterate once for each item in sequence,
such as an array. The `for` statement allows us to iterate a pre-determined
number of times, and control the process iteration. The `do-while` and `while`
statements allow us to iterate through a block of code with the intent that the
logic inside of the code block will affect when we can stop iterating.

Suppose you want to accept and process user input. You want to continue
accepting and processing input until the user presses the `q` key for "quit".
You can use the `do-while` and the `while` statements to keep iterating through
the logic to accept user input and process it until the user is ready to stop.

In this module, you'll use the `do-while` statement and the `while` statement to
iterate through code block. You'll understand when to choose one over the other.
You'll use the `continue` statement to skip the rest of the current iteration
and go directly to the next iteration.

### Learning objectives

In this module, you will:

- Write code that uses the `do-while` statement to iterate through a block of
  code until a condition is met.
- Write code that uses the `while` statement to iterate through a block of code
  until a condition is met.
- Use the `continue` statement to skip the rest of the current iteration and go
  directly to the next iteration.

## Exercise 1 - Create do and while iteration loops

On the surface, the `do-while` and `while` statements are yet another iteration
statement that allows you to iterate through a code block and thereby change the
flow of execution of your code. However, once we examine how each works, we can
better identify the nuances of each iteration statement and when to use them.

### What is the do-while statement?

The `do-while` statement executes a statement or a block of statements while a
specified Boolean expression evaluates to true. Because that expression is
evaluated after each execution of the loop, a do-while loop executes one or more
times.

The following code example shows the syntax of the `do-while` statement.

```csharp
do
{
    statement; // This statement is always executed at least once
} while (condition);
```

The flow of execution starts inside the curly brace. The code executes at least
one time, then the Boolean expression next to the `while` keyword is evaluated.
If the Boolean expressions returns `true`, the code block executed again.

By hard coding the Boolean expression to `true`, we've created an infite loop--a
loop that will never end, at least, not as it's currently written. We would need
a way to break out the loop inside of the code block. We'll discuss the exit
criteria of a do while in a bit.

Okay, now let's prepare our coding environment and begin our examination of code
samples that implement a `do-while` statement.

### Write a do-while statement to break when a certain random number is generated

Let's write code that will keep generating random numbers between 1 and 10 until
we generate the number 7. It could take just one iteration to get a 7, or it
could take dozens of iterations.

```csharp
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
```

#### Review your output

Since the numbers generated are random, your results will be different. However,
the value `7` will be the last number to be printed as the Boolean expression
will evaluate to `false` when 7 is generated and the flow of execution will exit
the code block.

```
Output:
8
1
10
8
8
8
6
1
2
9
5
4
2
8
4
8
2
7
```

#### Review the code

A key learning for this first task is that the code block of a `do-while` loop
will execute at least once. It could iterate a large number of times, and it is
unlikely that we know ahead of time how many iterations there will be.

It's also important to notice that the code inside of the code block is
influencing whether to continue iterating through the code block or not. A code
block that influences the exit criteria is a primary reason to select a
`do-while` or `while` statements rather than one of the other iteration
statements. Both the `foreach` and `for` rely on factors that are external to
the code block to determine the number of code block iterations.

### Write a while statement that iterates only while a random number is greater than some value

Now let's take a look at the while statement.

The `while` statement executes a statement or a block of statements while a
specified Boolean expression evaluates to true. Because that expression is
evaluated before each execution of the loop, a while loop executes zero or more
times.

```csharp
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
```

> [!NOTE] In this case, we position the `while` keyword and the Boolean
> expression before the code block. This changes the meaning of the code and
> acts as a "gate" to only allow the flow of execution to enter if the Boolean
> expression evaluates to true.

#### Review your output

Since the numbers generated are random, your results will be different. However,
the value `3` will be the last number to be printed as the Boolean expression
will evaluate to `false` when 3 is generated and the flow of execution will exit
the code block.

```
9
7
5
Last number: 1
```

#### Review the code

At the top code, we use `random` to initialize our `int` variable named
`current`. Our next active code line is our `while` statement.

Our `while` statement will iterate based on the Boolean expression `(current >=
3)`. We don't know what value will be assigned to `current`, but there are
possibilities that affect our `while` loop:

If `current` is initialized to a value greater than or equal to 3, then the
Boolean expression will return `true`, and the flow of execution will enter the
code block. Inside the code block, the first thing that we do is write the value
of `current` to the console. Next, still inside the code block, we update the
value of `current` with a new random value. At this point, control goes back to
the top of the `while` statement where the Boolean expression is evaluated. This
process continues until the Boolean expression returns `false` and the flow of
execution breaks from the code block. If `current` is initialized (at the top of
our code) to a value less than 3, then the Boolean expression will return
`false`, and the code block will never execute. The final code line writes the
value of `current` to the console. This code runs whether the iteration code
block was executed or not, and is our chance to write the final value of
`current` to the console.

### Use the continue statement to step directly to the Boolean expression

In certain cases, we want to short-circuit the remainder of the code in the code
block and continue to the next iteration. We can do that using the continue
statement.

Update the code from the previous task to use the `continue` statement.

```csharp
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/
```

#### Review your code

Notice that we've switched back to a `do-while`. A `do-while` ensures that the
loop will iterate at least once.

The first thing that we do inside the code block is to assign a new random value
to `current`. Next, we check to see if `current` is greater than or equal to 8.
If this expression returns `true`, the `continue` key word will transfer control
to the end of the code block and the while will evaluate `(current != 7)`. So,
the loop will continue to iterate as long as the value of `current` is not equal
to `7`.

The key to this step of the exercise is the line of code containing the
`continue` key word:

```csharp
if (current >= 8) continue;
```

Since our code that writes the value of `current` to the console is located
after the `if(current >= 8) continue;` our code ensures that a value of
`current` that is greater than or equal to `8` will never be written to the
output window.

Let's try out.

#### Review your output

Since the numbers generated are random, your results will be different. However,
the value `7` will be the last number to be printed as the Boolean expression
will evaluate to `false` when 7 is generated and the flow of execution will exit
the code block.

```
Output:
6
6
2
1
4
7
```

### Recap

There's a few key points to remember about the `do-while` and `while`
statements:

- The do-while statement iterates through a code block at least once, and might
  continue to iterate based on a Boolean expression. The evaluation of the
  Boolean expression usually depends on some value generated or retrieved inside
  of the code block.
- The while statement evaluates a Boolean expression first, and continues to
  iterate through the code block as long as the Boolean expression evaluates to
  true.
- The continue keyword to step immediately to the Boolean expression.

## Exercise 2 - Complete a challenge activity using do and while iteration statements

Code challenges will reinforce what you've learned and help you gain some
confidence before continuing on.

### Role playing game battle challenge

In some role playing games, the player's character battles non-player
characters, which are usually monsters or the "bad guys". Sometimes, a battle
consists of each character generating a random value using dice and that value
is subtracted from the opponent's health score. Once either character's health
reaches zero, they lose the game.

In this challenge, we'll boil down that interaction to its essence. A hero and a
monster start with the same health score. During the hero's turn, they'll
generate a random value which will be subtracted from the monster's health. If
the monster's health is greater than zero, they'll take their turn and attack
the hero. As long as both the hero and the monster have health greater than
zero, the battle will resume.

### Code challenge - write code to implement the game rules

Here are the rules for the battle game that you need to implement in your code
project:

- You must use either the do-while statement or the while statement as an outer
  game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or
  hero's health is zero or less.
- Print the winner.

No matter how you do it, your code should produce output similar to the
following:

```
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
```

Obviously, because of the random nature of the code, the outcome will be
different each time, so your results will definitely be different that the
output displayed above. However, you can use this as an example of the output
your code should generate.

### Review the solution to the code challenge

Here's one possible solution to the code challenge.

```csharp
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
```

This code is merely "one possible solution" because there are many different
ways to perform the attack logic.

## Exercise 3 - Complete a challenge activity to differentiate between do and while iteration statements

### Examine the difference between do and while statement iterations

As you have seen, C# supports four types of iteration statements: `for`,
`foreach`, `do-while`, and `while`. Microsoft's language reference documentation
describes these statements as follows:

- The for statement: executes its body while a specified Boolean expression (the
  'condition') evaluates to true.
- The foreach statement: enumerates the elements of a collection and executes
  its body for each element of the collection.
- The do-while statement: conditionally executes its body one or more times.
- The while statement: conditionally executes its body zero or more times.

The `for` and `foreach` iterations seem to be clearly differentiated from each
other and from the `do-while` and `while` iterations. The definitions for the
`do-while` and `while` statements, however, appear to be quite similar. Knowing
when to choose between a `do-while` and a `while` seems more arbitrary, and can
even be a bit confusing. Some challenge projects may help to make the
differences clear.

In this challenge, you'll be presented with conditions for three separate coding
projects. Each project will require you to implement an iteration code block
using either a `do-while` or a `while` statement. You'll need to evaluate the
specified conditions in order to choose between the `do-while` and `while`
statements. You can switch after you start if your first choice isn't working
out as well as you had hoped.

> [!NOTE] The conditions for your coding project can be used to help you select
> between the `do-while` and `while` statements. What you know, or don't know, about
> the Boolean expression that will be evaluated can sometimes help you to select
> between the `do-while` and `while` statements. In this challenge exercise, the
> project conditions include information that will be used to construct the
> Boolean expression.

### Manage user input during this challenge

When using a `Console.ReadLine()` statement to obtain user input, it's common
practice to use a nullable type string (designated `string?`) for the input
variable and then evaluate the value entered by the user. The following code
sample uses a nullable type string to capture user input. The iteration
continues while the user-supplied value is null:

```csharp
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
```

The Boolean expression evaluated by the `while` statement can be used to ensure user input meets a specified requirement. For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:

```csharp
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```

If you want to use `Console.ReadLine()` input for numeric values, you need to convert the string value to a numeric type.

The `int.TryParse()` method can be used to convert a string value to an integer.
The method uses two parameters, a string that will be evaluated and the name of
an integer variable that will be assigned a value. The method returns a Boolean
value. The following code sample demonstrates using the `int.TryParse()` method:

```csharp
// capture user input in a string variable named readResult

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
```

If the string value assigned to `readResult` represents a valid integer, the value
will be assigned to the integer variable named `numericValue`, and `true` will be
assigned to the Boolean variable named `validNumber`. If the value assigned to
`readResult` doesn't represent a valid integer, `validNumber` will be assigned a
value of `false`. For example, if `readResult` is equal to "7", the value `7` will be
assigned to `numericValue`.

### Code project 1 - write code that validates integer input

Here are the conditions that your first coding project must implement:

- Your solution must include either a `do-while` or `while` iteration.

- Before the iteration block: your solution must use a `Console.WriteLine()` statement to prompt the user for an integer value between 5 and 10.

- Inside the iteration block:

    - Your solution must use a `Console.ReadLine()` statement to obtain input from the user.
    - Your solution must ensure that the input is a valid representation of an integer.
    - If the integer value isn't between 5 and 10, your code must use a `Console.WriteLine()` statement to prompt the user for an integer value between 5 and 10.
    - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.

- Below (after) the iteration code block: your solution must use a
`Console.WriteLine()` statement to inform the user that their input value has been
accepted.

#### Code

[C#](./Exercises/CP1/Program.cs)

### Code project 2 - write code that validates string input

Here are the conditions that your second coding project must implement:

- Your solution must include either a do-while or while iteration.

- Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

- Inside the iteration block:

    - Your solution must use a Console.ReadLine() statement to obtain input from the user.
    - Your solution must ensure that the value entered matches one of the three role options.
    - Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
    - Your solution should use the ToLower() method on the input value to ignore case.
    - If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.

- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

The console output for this example should look similar to the following:

```output
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
```

#### Code

[C#](./Exercises/CP2/Program.cs)

### Code project 3 - Write code that processes the contents of a string array

Here are the conditions that your third coding project must implement:

- your solution must use the following string array to represent the input to your coding logic:

```csharp
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
```

- Your solution must declare an integer variable named `periodLocation` that can be used to hold the location of the period character within a string.

- Your solution must include an outer `foreach` or `for` loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named `myString`.

- In the outer loop, your solution must use the `IndexOf()` method of the `String` class to get the location of the first period character in the `myString` variable. The method call should be similar to: `myString.IndexOf(".")`. If there's no period character in the string, a value of -1 will be returned.

- Your solution must include an inner `do-while` or `while` loop that can be used to process the `myString` variable.

- In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

- In the inner loop, your solution must not display the period character.

- In the inner loop, your solution must use the `Remove()`, `Substring()`, and
`TrimStart()` methods to process the string information.

Your solution should produce output similar to the following:

```output
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
```

### Review the solution to the code challenge

The following examples should use a `do` because you know that you need to execute
the code block at least once. You CAN also use a `while` to achieve the same
result. Some developers feel that the logic of a `while` makes the code more
readable. If that is the case for you, you can choose to implement a `while`. In
this case, be aware that most code compilers will optimize your code for you by
converting the iteration statement to a `do-while`.

#### Project 1 code

The following code is one possible solution for challenge project 1 from the previous unit.

The code uses a `do` statement because the code block must be executed at least
once. You CAN also use a `while` to achieve the same result. Some developers may
feel that the logic of a `while` makes the code more readable. If that's the case
for you, you can choose to implement a `while` statement here.

```csharp
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
```

#### Project 2 code

The following code is one possible solution for challenge project 2 from the previous unit.

The code uses a `do` statement because the code block must be executed at least
once. You CAN also use a `while` to achieve the same result. Some developers may
feel that the logic of a `while` makes the code more readable. If that's the case
for you, you can choose to implement a `while` statement here.

```csharp
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
```

#### Project 3 code

The following code is one possible solution for challenge project 3 from the previous unit.

The code uses a `for` statement for the outer loop because you cannot modify the value assigned to a 'foreach iteration variable'. You could work around this by declaring an additional string variable inside the `foreach` loop, but then you would be adding unwanted complexity to your code logic. In other words, using the iteration statement `foreach (string myString in myStrings)` and then attempting to process the `myString` variable will generate a compilation error.

The code uses a `while` statement for the inner loop because, depending on the value of the data string, the code block may not be executed (when the string does not contain a period). You should not use a `do` statement in situations where the iteration block may not need to be executed.

```csharp
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
```

## Summary

Your goal was to use the `do-while` and `while` statements to perform iterations. The `do-while` and `while` statements are unique because the body of the code block determines whether the flow of execution should continue or stop.

Using the `do-while` statement, you executed a block of code once before evaluating a Boolean expression and potentially exiting the iteration. Using the `while` statement, you performed the evaluation of the Boolean expression immediately, and continued to evaluate it to exit the iteration. You used the `continue` statement within the code block to step directly to the Boolean expression.

You developed a practical application that uses the `do-while` and `continue` statements to simulate a battle in a role playing game. Real-world scenarios involving the `do-while` and `while` iteration statements involve working with streams of data from files, from the internet, or any other scenario where you'll continue to perform an iteration until a condition is met.

Without `do-while` and `while` iteration statements, it would be difficult to write and maintain iteration code that sets the exit condition within the iteration code block.

## Achievement

![Achievement](achievement.png)
