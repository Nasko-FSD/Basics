Console.Write("Enter a number N: ");
var N = int.Parse(Console.ReadLine());
Console.Write("Enter a number M: ");
var M = int.Parse(Console.ReadLine());
Console.Write("Enter a number Stop: ");
var Stop = int.Parse(Console.ReadLine());
for (int i = M; i >= N; i--)
{
    if (i % 2 == 0 && i % 3 == 0 && i == Stop)
    {
        break;
    }
    else if (i % 2 == 0 && i % 3 == 0 && i != Stop)
    {
        Console.Write("{0} ", i);
    }
}