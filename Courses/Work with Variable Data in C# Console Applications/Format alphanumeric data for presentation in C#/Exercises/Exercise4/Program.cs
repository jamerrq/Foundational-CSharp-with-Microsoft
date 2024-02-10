string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Dear " + customerName + ",");
Console.WriteLine("As a valued customer of our Magic Yield offerings, we are excited to inform you of a new product that would maximize your investment.");

Console.WriteLine($"Currently, you own {currentShares:N0} shares at a return of {currentReturn:P2}.");

Console.WriteLine($"Our new product, {newProduct}, offers a return of {newReturn:P2}. Given your current volume, your potential profit would be ¤63,000,000.00.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

comparisonMessage = $"{currentProduct,-20} {currentReturn,8:P2} {currentProfit,15:C}\n";
comparisonMessage += $"{newProduct,-20} {newReturn,8:P2} {newProfit,15:C}";

Console.WriteLine(comparisonMessage);
