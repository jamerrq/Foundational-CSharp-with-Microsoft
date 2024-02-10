// Format alphanumeric data for presentation in C#

using System;

// Formatting strings

string first = "Hello";
string second = "C#";

string result = string.Format("{0}, {1}!", first, second);
Console.WriteLine("string.Format(\"{0}, {1}!\")");
Console.WriteLine(result);

string result2 = string.Format("{0} {0} {0}", first, second);
Console.WriteLine("string.Format(\"{0} {0} {0}\")");
Console.WriteLine(result2);

// Formatting currency

decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine("Price: {price:C} Discount: {discount:C}");
Console.WriteLine($"Price: {price1:C} Discount: {discount:C}");

// Formatting numbers

decimal measurement = 123456.78912m;
Console.WriteLine("Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatting percentages

decimal tax = 0.07m;
Console.WriteLine("Tax: {tax:P}");
Console.WriteLine($"Tax rate: {tax:P}");

// Combining formatting options

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

decimal tax2 =.12051m;
Console.WriteLine($"Tax rate: {tax2:P1}");
