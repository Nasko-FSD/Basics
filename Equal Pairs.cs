Console.Write("Enter how many pairs you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter {0} pairs: ", n);
double SumOne = 0;
double SumTwo = 0;
double maxdiff = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write("pair {0}= ", i);
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    if (i % 2 != 0)
    {
        SumOne = num1 + num2;
    }
    if (i % 2 == 0)
    {
        SumTwo = num1 + num2;
    }
}
maxdiff = Math.Abs(SumOne - SumTwo);
if (SumOne == SumTwo || n < 2)
{
    Console.WriteLine("Yes,value= " + SumOne);
}
else
{
    Console.WriteLine("No,maxdiff= " + maxdiff);
}