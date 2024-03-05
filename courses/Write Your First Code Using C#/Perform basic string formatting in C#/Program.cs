/*
Format literal strings in C#.
*/


/*
Character escape sequences

An escape character sequence is an instruction to the runtime to insert a
special character that will affect the output of your string. In C#, the escape
character sequence begins with a backslash \ followed by the character you're
escaping. For example, the \n sequence will add a new line, and a \t sequence
will add a tab.

The following code uses escape character sequences to add newlines and tabs:
*/

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

/*
What if you need to insert a double-quotation mark in a literal string? If you
don't use the character escape sequence, you'll confuse the compiler because it
will think you want to terminate the string prematurely. The compiler won't
understand the purpose of the characters after the second double-quotation mark.

To handle that situation, use the \" escape sequence:
*/
Console.WriteLine("Hello \"World\"!");

// What if you need to use the backslash for other purposes, like to display a
// file path?
Console.WriteLine("c:\\source\\repos");

/*
Verbatim string literal

A verbatim string literal is a string that ignores escape characters and newline
characters. It's useful when you want to display a string exactly as you've
typed it. To create a verbatim string literal, prefix the string with the @
symbol. The following code uses a verbatim string literal to display a file
path:
*/

Console.WriteLine(@"c:\source\repos");

/*
Unicode escape sequences

Unicode escape sequences are used to display characters that aren't available on
your keyboard. For example, the following code uses a Unicode escape sequence to
display the Greek letter alpha (α):
*/
Console.WriteLine("\u03A9");

/*
Recap

Here's a quick recap of what you've learned so far in this section:

- Use character escape sequences to insert special characters in a string. Like
  \n for a new line, \t for a tab, and \" for a double-quotation mark.
- Use an escape character for the backslash itself, like \\ when you need to
  display it in a string.
- Use the @ symbol to create a verbatim string literal that ignores escape
  characters and newlines.
- Use a Unicode escape sequence to display characters that aren't available on
    your keyboard.
*/

/*
Combine strings using string concatenation

Often, you'll need to combine data from many different sources, including
literal strings and variables containing both text and numeric data. In this
unit, you'll use string concatenation to combine two or more values into a new
string.


What is string concatenation?

String concatenation is "programmer speak" for combining two or more strings
into a single string. Unlike addition, the second value is appended to the end
of the first value and so on.
*/

/*
Concatenate a literal string and a variable

To concatenate two strings together you use the string concatenation operator,
which is the plus sign +.
*/
string firstName = "Bob";
string message1 = "Hello " + firstName;
Console.WriteLine(message1);

/*
Concatenate multiple variable and literal strings

You can perform several concatenation operations in the same line of code.
*/
// string firstName = "Bob";
string greeting = "Hello";
string message2 = greeting + " " + firstName + "!";

/*
Avoid intermediate variables

In the previous example, you created three variables to store the first name,
the greeting, and the final message. But you don't need to create intermediate
variables. You can concatenate the strings directly in the Console.WriteLine()
method call.
*/
// string firstName = "Bob";
Console.WriteLine("Hello " + firstName + "!");

/*
Recap

Here's a quick recap of what you've learned so far in this section:

- String concatenation allows you to combine two or more strings into a single
  string.
- Avoid creating intermediate variables when concatenating strings.
*/


/*
Combine strings using string interpolation

While string concatenation is simple and convenient, string interpolation is
growing in popularity because it's easier to read and maintain. It's also more
convenient in situations where you need to combine many literal strings and
variables into a single formatted string.

What is string interpolation?

String interpolation is a way to construct a new string value that contains the
values of other variables and literals. It's similar to string concatenation,
but instead of using the + operator, you use the $ symbol and {} braces.
*/

/*
Example of string interpolation
*/

// string firstName = "Bob";
// string greeting = "Hello";
// Instead of greeting + " " + firstName + "!"
string message3 = $"{greeting} {firstName}!";

/*
Use string interpolation with multiple variables and literal strings

You can perform several interpolation operations in the same line of code.
*/
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

/*
Avoid intermediate variables

Just like with string concatenation, you don't need to create intermediate
variables. You can interpolate the strings directly in the
Console.WriteLine() method call.
*/
Console.WriteLine($"{updateText} {version}!");

/*
Combine verbatim literals and string interpolation

Suppose you need to use a verbatim literal in your template. You can use both
the verbatim literal prefix symbol @ and the string interpolation $ symbol
together.
*/
string filePath = @"C:\source\repos";
string message4 = $@"{filePath}\index.html";

/*
Recap

- String interpolation allows you to combine two or more strings into a single
  string.
- Avoid creating intermediate variables when interpolating strings.
- You can use both the verbatim literal prefix symbol @ and the string
  interpolation $ symbol together.
*/

/*
CHALLENGE
*/

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English Output:");
Console.WriteLine($@"   c:\Exercise\{projectName}\data.txt");
Console.WriteLine($"\n{russianMessage}:");
Console.WriteLine($@"   c:\Exercise\{projectName}\ru-RU\data.txt");
