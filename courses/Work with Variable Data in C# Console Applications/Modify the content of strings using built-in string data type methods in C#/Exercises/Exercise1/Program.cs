// Write code to find parenthesis pairs embedded in a string

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition); // 13
Console.WriteLine(closingPosition); // 36

int length = closingPosition - openingPosition;
string inside = message.Substring(openingPosition + 1, length - 1); // (inside the parentheses

openingPosition += 1;

int length2 = closingPosition - openingPosition;
string inside2 = message.Substring(openingPosition, length2); // inside the parentheses

message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

openingPosition = message.IndexOf(openSpan);
closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); // between the tags
