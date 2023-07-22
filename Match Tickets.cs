Console.Write("Enter the budget: ");
double budget = double.Parse(Console.ReadLine());
Console.Write("Enter the category: ");
string category = (Console.ReadLine());
Console.Write("Enter the number of people: ");
double people = double.Parse(Console.ReadLine());
double bill = 0;
if (people >= 1 && people <= 4)
{
    if (category == "Normal")
    {
        bill = (budget - (budget * 0.75)) - (people * 249.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
    else if (category == "VIP")
    {
        bill = (budget - (budget * 0.75)) - (people * 499.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
}
if (people >= 5 && people <= 9)
{
    if (category == "Normal")
    {
        bill = (budget - (budget * 0.60)) - (people * 249.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
    else if (category == "VIP")
    {
        bill = (budget - (budget * 0.60)) - (people * 499.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
}
if (people >= 10 && people <= 24)
{
    if (category == "Normal")
    {
        bill = (budget - (budget * 0.50)) - (people * 249.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
    else if (category == "VIP")
    {
        bill = (budget - (budget * 0.50)) - (people * 499.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
}
if (people >= 25 && people <= 49)
{
    if (category == "Normal")
    {
        bill = (budget - (budget * 0.40)) - (people * 249.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
    else if (category == "VIP")
    {
        bill = (budget - (budget * 0.40)) - (people * 499.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
}
if (people >= 50)
{
    if (category == "Normal")
    {
        bill = (budget - (budget * 0.25)) - (people * 249.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
    else if (category == "VIP")
    {
        bill = (budget - (budget * 0.25)) - (people * 499.99);
        Console.WriteLine(bill >= 0 ? "Yes! You have {0:f2} leva left."
            : "Not enough money! You need {0:f2} leva.", Math.Abs(bill));
    }
}