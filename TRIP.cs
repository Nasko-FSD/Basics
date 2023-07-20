Console.Write("Enter the budget: ");
double budget = double.Parse(Console.ReadLine());
Console.Write("Enter the season - summer or winter: ");
string season = (Console.ReadLine());
if (budget <= 100)
{
    if (season == "summer")
    {
        budget = budget * 30 / 100;
        Console.WriteLine("Somewhere in Bulgaria");
        Console.WriteLine("Camp - {0:f2}", budget);
    }
    else if (season == "winter")
    {
        budget = budget * 70 / 100;
        Console.WriteLine("Somewhere in Bulgaria");
        Console.WriteLine("Hotel - {0:f2}", budget);
    }
}
if (budget > 100 && budget <= 1000)
{
    if (season == "summer")
    {
        budget = budget * 40 / 100;
        Console.WriteLine("Somewhere in Balkans");
        Console.WriteLine("Camp - {0:f2}", budget);
    }
    else if (season == "winter")
    {
        budget = budget * 80 / 100;
        Console.WriteLine("Somewhere in Balkans");
        Console.WriteLine("Hotel - {0:f2}", budget);
    }
}
if ( budget > 1000 )
{
    if (season == "summer")
    {
        budget = budget * 90 / 100;
        Console.WriteLine("Somewhere in Europe");
        Console.WriteLine("Hotel - {0:f2}", budget);
    }
    else if (season == "winter")
    {
        budget = budget * 90 / 100;
        Console.WriteLine("Somewhere in Europe");
        Console.WriteLine("Hotel - {0:f2}", budget);
    }
}