/*
Exercise: Complete a challenge to extract, replace, and remove data from an input string

Code challenges reinforce learning and help you gain some confidence before continuing on.

In this challenge, you work with a string that contains a fragment of HTML. You extract data from the HTML fragment, replace some of its content, and remove other parts of its content to achieve the desired output.

If you're unfamiliar with HTML code, review the "Quick HTML primer" section at the end of this unit.
*/

// Extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

int openingPosition = input.IndexOf("<span>");
int closingPosition = input.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);

output = input.Replace("&trade;", "&reg;");
output = output.Remove(0, 5);
output = output.Remove(output.Length - 6);

Console.WriteLine(quantity);
Console.WriteLine(output);
