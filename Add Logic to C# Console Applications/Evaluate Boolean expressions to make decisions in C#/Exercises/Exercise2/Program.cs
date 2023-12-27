// Add code that uses a conditional operator

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// Use the conditional operator inline
/*
You can compact this code even more by eliminating the temporary variable discount.
*/
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
