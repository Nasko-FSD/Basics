Console.Write("Enter the input type of currency: ");
var inputtype = Console.ReadLine();
Console.Write("Enter the output type of currency: ");
var outputtype = Console.ReadLine();
Console.Write("Enter the amount: ");
double amount = double.Parse(Console.ReadLine());
double USDtoBGN = amount * 1.79549;
double BGNtoUSD = amount / 1.79549;
double USDtoEUR = amount / 1.0893015;
double EURtoUSD = amount * 1.79549;
double EURtoGBP = amount / 1.2956;
double GBPtoEUR = amount * 1.29563;
double BGNtoEUR = amount / 1.95583;
double EURtoBGN = amount * 1.95583;
double BGNtoGBP = amount / 2.53405;
double GBPtoBGN = amount * 2.53405;
double GBPtoUSD = amount * 1.41134;
double USDtoGBP = amount / 1.41134;
if (inputtype == "USD") 
if (outputtype == "BGN") 
{
    Console.WriteLine(Math.Round(USDtoBGN, 2));
}
if (inputtype == "BGN") 
if (outputtype == "USD") 
{
    Console.WriteLine(Math.Round(BGNtoUSD, 2));
}
if (inputtype == "USD") 
if (outputtype == "EUR") 
{
    Console.WriteLine(Math.Round(USDtoEUR, 2));
}
if (inputtype == "EUR") 
if (outputtype == "USD") 
{
    Console.WriteLine(Math.Round(EURtoUSD, 2));
}
if (inputtype == "EUR") 
if (outputtype == "GBP") 
{
    Console.WriteLine(Math.Round(EURtoGBP, 2));
}
if (inputtype == "GBP") 
if (outputtype == "EUR") 
{ 
    Console.WriteLine(Math.Round(GBPtoEUR, 2));
}
if (inputtype == "BGN") 
if (outputtype == "EUR") 
{
    Console.WriteLine(Math.Round(BGNtoEUR, 2));
}
if (inputtype == "EUR") 
if (outputtype == "BGN") 
{
    Console.WriteLine(Math.Round(EURtoBGN, 2));
}
if (inputtype == "BGN") 
if (outputtype == "GBP") 
{
    Console.WriteLine(Math.Round(BGNtoGBP, 2));
}
if (inputtype == "GBP") 
if (outputtype == "BGN") 
{
    Console.WriteLine(Math.Round(GBPtoBGN, 2));
}
if (inputtype == "GBP")
if (outputtype == "USD")
{
    Console.WriteLine(Math.Round(GBPtoUSD, 2));
}
if (inputtype == "USD")
if (outputtype == "GBP")
{
    Console.WriteLine(Math.Round(USDtoGBP, 2));
}