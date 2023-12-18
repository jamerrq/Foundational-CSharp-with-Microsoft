/*
In this challenge, you'll use the techniques you learned in this module to
improve the readability of a code sample. You are provided with a code sample
that is poorly styled and commented. Your goal is to update the code using style
guidelines for variable names, code comments, and whitespace to improve code
readability.
*/

/*
This program reverses a message and counts the number of times the letter 'o'
appears in the message (in this case "The quick brown fox jumps over the lazy
dog.") and prints the result to the console.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;
foreach (char i in message)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
