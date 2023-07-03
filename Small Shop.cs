Console.Write("Enter town name: ");
var town = Console.ReadLine().ToLower();
Console.Write("Enter product name: ");
var product = Console.ReadLine().ToLower();
Console.Write("Enter quantity: ");
double quantity = double.Parse(Console.ReadLine());
if (town == "sofia")
{
    if (product == "coffee") Console.WriteLine(Math.Round(quantity * 0.50, 2));
    else if (product == "water") Console.WriteLine(Math.Round(quantity * 0.80, 2));
    else if (product == "beer") Console.WriteLine(Math.Round(quantity * 1.20, 2));
    else if (product == "sweets") Console.WriteLine(Math.Round(quantity * 1.45, 2));
    else if (product == "peanuts") Console.WriteLine(Math.Round(quantity * 1.60, 2));
}
else if (town == "plovdiv")
{
    if (product == "coffee") Console.WriteLine(Math.Round(quantity * 0.40, 2));
    else if (product == "water") Console.WriteLine(Math.Round(quantity * 0.70, 2));
    else if (product == "beer") Console.WriteLine(Math.Round(quantity * 1.15, 2));
    else if (product == "sweets") Console.WriteLine(Math.Round(quantity * 1.30, 2));
    else if (product == "peanuts") Console.WriteLine(Math.Round(quantity * 1.50, 2));
}
else if (town == "varna")
{
    if (product == "coffee") Console.WriteLine(Math.Round(quantity * 0.45, 2));
    else if (product == "water") Console.WriteLine(Math.Round(quantity * 0.70, 2));
    else if (product == "beer") Console.WriteLine(Math.Round(quantity * 1.10, 2));
    else if (product == "sweets") Console.WriteLine(Math.Round(quantity * 1.35, 2));
    else if (product == "peanuts") Console.WriteLine(Math.Round(quantity * 1.55, 2));
}
