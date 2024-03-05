string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal result = 0;
string message = string.Empty;
decimal sum = 0;
foreach (var value in values) {
    if (decimal.TryParse(value, out result)) {
        sum += result;
    } else {
        message += $"{value}";
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");
