Console.Write("Enter the kilometers: ");
int kilometers = int.Parse(Console.ReadLine());
Console.Write("Enter the period - day or night: ");
string period = Console.ReadLine();
double price = 0;
double taxistartingfee = 0.70;
double taxidayrate = 0.79;
double taxinightrate = 0.90;
double bus = 0.09;
double train = 0.06;
if (kilometers < 20 && period == "day")
{
    price = taxistartingfee + (kilometers * taxidayrate);
}
else if ( kilometers < 20 && period == "night")
{
    price = taxistartingfee + (kilometers * taxinightrate);
}
if (kilometers >= 20 && kilometers < 100)
{
    price = kilometers * bus;
}
else if (kilometers >= 100 && kilometers <= 5000)
{
    price = kilometers * train;
}
Console.WriteLine("The price is: " + Math.Round(price, 2));