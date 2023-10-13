var n = int.Parse(Console.ReadLine());
var asterisk = 1;
if (n % 2 == 0)
{
    asterisk = 2;
}
for (int upper = 1; upper <= (n + 1) / 2; upper++)
{
    Console.Write(new string('-', (n - asterisk) / 2));
    Console.Write(new string('*', asterisk));
    Console.WriteLine(new string('-', (n - asterisk) / 2));
    asterisk += 2;
}
for (int lower = 1; lower <= n / 2; lower++)
{
    Console.Write("|");
    for (int stars = 1; stars <= n - 2; stars++)
    {
        Console.Write("*");
    }
    Console.WriteLine("|");
}