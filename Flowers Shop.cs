double Bouquet = 2;
double Chrysantemumspcs = double.Parse(Console.ReadLine());
double Rosespcs = double.Parse(Console.ReadLine());
double Tulipspcs = double.Parse(Console.ReadLine());
string Season = Console.ReadLine().ToLower();
string Holiday = Console.ReadLine().ToLower();
double TotalPriceAW = 0;
double TotalPriceSS = 0;
if (Season == "autumn" || Season == "winter")
{
    double ChryAW = (Chrysantemumspcs * 3.75);
    double RosesAW = (Rosespcs * 4.50);
    double TulipsAW = (Tulipspcs * 4.15);
    TotalPriceAW = ChryAW + RosesAW + TulipsAW;
}
if (Season == "spring" || Season == "summer")
{
    double ChrySS = (Chrysantemumspcs * 2.00);
    double RosesSS = (Rosespcs * 4.10);
    double TulipsSS = (Tulipspcs * 2.50);
    TotalPriceSS = ChrySS + RosesSS + TulipsSS;
}
if (Holiday == "y")
{
    TotalPriceAW = TotalPriceAW + (TotalPriceAW * 15 / 100);
    TotalPriceSS = TotalPriceSS + (TotalPriceSS * 15 / 100);
}
if (Season == "spring" && Tulipspcs > 7)
{
    TotalPriceSS -= (TotalPriceSS * 5 / 100);
}
if (Season == "winter" && Rosespcs >= 10)
{
    TotalPriceAW -= (TotalPriceAW * 10 / 100);
}
if (Chrysantemumspcs + Rosespcs + Tulipspcs > 20)
{
    TotalPriceAW = TotalPriceAW - (TotalPriceAW * 20 / 100);
    TotalPriceSS = TotalPriceSS - (TotalPriceSS * 20 / 100);
}
if (Season == "autumn" || Season == "winter")
{
    Console.WriteLine("{0:f2}", TotalPriceAW + Bouquet);
}
if (Season == "spring" || Season == "summer")
{
    Console.WriteLine("{0:f2}", TotalPriceSS + Bouquet);
}