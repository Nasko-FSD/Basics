//Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter {0} numbers: ", n);
double EvenSum = 0;
double OddSum = 0;
double EvenMax = double.MinValue;
double EvenMin = double.MaxValue;
double OddMax = double.MinValue;
double OddMin = double.MaxValue;
for (int i = 1; i <= n; i++)
{
    //Console.Write("num {0}= ", i);
    double num = double.Parse(Console.ReadLine());
    if (i % 2 == 0 && num > EvenMax)
    {
        EvenMax = num;
    }
    if (i % 2 == 0 && num < EvenMin)
    {
        EvenMin = num;
    }
    if (i % 2 != 0 && num > OddMax)
    {
        OddMax = num;
    }
    if (i % 2 != 0 && num < OddMin)
    {
        OddMin = num;
    }
    if (i % 2 == 0)
    {
        EvenSum += +num;
    }
    if (i % 2 != 0)
    {
        OddSum += +num;
    }
}
Console.WriteLine("OddSum= " + OddSum);
if (OddMin == double.MaxValue)
{
    Console.WriteLine("OddMin No");
}
else
{
    Console.WriteLine("OddMin= " + OddMin);
}
if (OddMax == double.MinValue)
{
    Console.WriteLine("OddMax No");
}
else
{
    Console.WriteLine("OddMax= " + OddMax);
}
Console.WriteLine("EvenSum= " + EvenSum);
if (EvenMin == double.MaxValue)
{
    Console.WriteLine("EvenMin No");
}
else
{
    Console.WriteLine("EvenMin= " + EvenMin);
}
if (EvenMax == double.MinValue)
{
    Console.WriteLine("EvenMax No");
}
else
{
    Console.WriteLine("EvenMax= " + EvenMax);
}