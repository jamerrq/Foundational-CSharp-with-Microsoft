// Retrieve the last occurrence of a sub string

/*
You increase the complexity of the message variable by adding many sets of parentheses, then write code to retrieve the content inside the last set of parentheses.
*/

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// Retrieve all instances of substrings inside parentheses

/*
This time, update the message to have three sets of parentheses, and write code to extract any text inside of the parentheses. You're able to reuse portions of the previous work, but you need to add a while statement to iterate through the string until all sets of parentheses are discovered, extracted, and displayed.
*/

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// Work with different types of symbol sets

/*
This time, search for several different symbols, not just a set of parentheses.

Update the message string, adding different types of symbols like square [] brackets and curly braces {}. To search for multiple symbols simultaneously, use .IndexOfAny(). You search with .IndexOfAny() to return the index of the first symbol from the array openSymbols found in the message string.
*/

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

/* OUTPUT

Searching THIS message: Help (find) the {opening symbols}
Found WITHOUT using startPosition: (find) the {opening symbols}
Found WITH using startPosition 5:  (find) the {opening symbols}

*/

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters.
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through
// the characters in the string. This time, use the closing
// position of the previous iteration as the starting index for the
//next open symbol. So, you need to initialize the closingPosition
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify
    // that the search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
