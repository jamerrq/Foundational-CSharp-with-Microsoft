int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = (int)((value1 / value2) + 0.5m);
decimal result2 = value2 / (decimal)value3;
float result3 = value3 / value1;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
