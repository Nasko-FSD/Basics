Console.Write("Enter the month: ");
string month = (Console.ReadLine()).ToLower();
Console.Write("Enter the overnight stays: ");
double overnight = double.Parse(Console.ReadLine());
double billstudio = 0;
double billapartment = 0;
if (month == "may" || month == "october")
{
    if (overnight > 7 && overnight <= 14)
    {
        billstudio = (50 - (50 * 0.05)) * overnight;
        billapartment = 65 * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
    else if (overnight > 14)
    {
        billstudio = (50 - (50 * 0.3)) * overnight;
        billapartment = (65 - (65 * 0.1)) * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
    else if (overnight <= 7)
    {
        billstudio = 50 * overnight;
        billapartment = 65 * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
}
if (month == "june" || month == "september")
{
    if (overnight > 14)
    {
        billstudio = (75.20 - (75.20 * 0.2)) * overnight;
        billapartment = (68.70 - (68.70 * 0.1)) * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
    else if (overnight <= 14)
    {
        billstudio = 75.20 * overnight;
        billapartment = 68.70 * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
}
if (month == "july" || month == "august")
{
    if (overnight > 14)
    {
        billstudio = 76 * overnight;
        billapartment = (77 - (77 * 0.1)) * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
    else if (overnight <= 14)
    {
        billstudio = 76 * overnight;
        billapartment = 77 * overnight;
        Console.WriteLine("Apartment: {0:f2} lv.", billapartment);
        Console.WriteLine("Studio: {0:f2} lv.", billstudio);
    }
}