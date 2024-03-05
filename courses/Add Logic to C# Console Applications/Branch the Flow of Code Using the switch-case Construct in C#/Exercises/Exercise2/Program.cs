// SKU = Stock Keeping Unit.
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

// BEFORE - if-else statement

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }
//
// if (product[1] == "BL")
// {
//     color = "Black";
// }
// else if (product[1] == "MN")
// {
//     color = "Maroon";
// }
// else
// {
//     color = "White";
// }
//
// if (product[2] == "S")
// {
//     size = "Small";
// }
// else if (product[2] == "M")
// {
//     size = "Medium";
// }
// else if (product[2] == "L")
// {
//     size = "Large";
// }
// else
// {
//     size = "One Size Fits All";
// }

// AFTER - switch statement
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}


switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
