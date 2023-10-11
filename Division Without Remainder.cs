var n = int.Parse(Console.ReadLine());
double p1 = 0;
double p2 = 0;
double p3 = 0;
for (int i = 1; i <= n; i++)
{
    var numbers = int.Parse(Console.ReadLine());
    if (numbers % 2 == 0)
    {
        p1++;
    }
    if (numbers % 3 == 0)
    {
        p2++;
    }
    if (numbers % 4 == 0)
    {
        p3++;
    }
}
Console.WriteLine("{0:f2}%", p1 / n * 100);
Console.WriteLine("{0:f2}%", p2 / n * 100);
Console.WriteLine("{0:f2}%", p3 / n * 100);