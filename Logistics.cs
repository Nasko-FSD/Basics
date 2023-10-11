var loads = int.Parse(Console.ReadLine());
double bus = 0;
double truck = 0;
double train = 0;
var busprice = 200;
var truckprice = 175;
var trainprice = 120;
for (int i = 0; i < loads; i++)
{
    var tons = int.Parse(Console.ReadLine());
    if (tons >= 0 && tons <= 3)
    {
        bus += tons;
    }
    if (tons > 3 && tons <= 11)
    {
        truck += tons;
    }
    if (tons > 11)
    {
        train += tons;
    }
}
var SumOfTons = (bus + truck + train);
Console.WriteLine("{0:f2}", (bus * busprice + truck * truckprice + train * trainprice) / SumOfTons);
Console.WriteLine("{0:f2}%", bus / SumOfTons * 100);
Console.WriteLine("{0:f2}%", truck / SumOfTons * 100);
Console.WriteLine("{0:f2}%", train / SumOfTons * 100);