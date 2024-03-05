// Use the Remove() method

/*
You would typically use Remove() when there's a standard and consistent position of the characters you want to remove from the string.

This exercise has data stored in older files having a fixed length, and with character positions allocated for certain fields of information. The first five digits represent a customer identification number. The next 20 digits contain a customer's name. The next six positions represent the customer's latest invoice amount, and the last three positions represent the number of items ordered on that invoice.

In the following steps, you need to remove the customer's name to format the data so that it can be sent to a separate process. Since you know the exact position and length of the user's name, you can easily remove it using the Remove() method.
*/

// Remove characters in specific locations from a string

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

/* OUTPUT
123455000  3
*/

// Use the Replace() method

/*
The Replace() method is used when you need to replace one or more characters with a different character (or no character). The Replace() method is different from the other methods used so far, it replaces every instance of the given characters, not just the first or last instance.
*/

// Remove characters no matter where they appear in a string

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

/* OUTPUT
This is example data
*/
