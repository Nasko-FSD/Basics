Console.Write("Enter name on city: ");
var city = (Console.ReadLine()).ToLower();
Console.Write("Enter the amount of sales: ");
double sales = double.Parse(Console.ReadLine());
var comissions = -1.0;
if (city == "sofia")
{
    if (sales >= 0 && sales <= 500)
    {
        comissions = 0.05;
    }
    else if (sales > 500 && sales <= 1000)
    {
        comissions = 0.07;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        comissions = 0.08;
    }
    else if (sales > 10000)
    {
        comissions = 0.12;
    }
}
else if (city == "varna")
{
    if (sales >= 0 && sales <= 500)
    {
        comissions = 0.045;
    }
    else if (sales > 500 && sales <= 1000)
    {
        comissions = 0.075;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        comissions = 0.10;
    }
    else if (sales > 10000)
    {
        comissions = 0.13;
    }
}
else if (city == "plovdiv")
{
    if (sales >= 0 && sales <= 500)
    {
        comissions = 0.055;
    }
    else if (sales > 500 && sales <= 1000)
    {
        comissions = 0.08;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        comissions = 0.12;
    }
    else if (sales > 10000)
    {
        comissions = 0.145;
    }
}
if (comissions >= 0)
{
    Console.WriteLine("{0:f2}", sales * comissions);
}
else 
{
    Console.WriteLine("error");
}