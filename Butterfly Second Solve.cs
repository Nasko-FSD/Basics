var n = int.Parse(Console.ReadLine());
var stars = n - 2;
var hyphens = n - 2;
for (int upper = 1; upper <= n - 2; upper++)
{
    if (upper % 2 == 1)
    {
        Console.WriteLine("{0}\\ /{0}", new string('*', stars));
    }
    if (upper % 2 == 0)
    {
        Console.WriteLine("{0}\\ /{0}", new string('-', hyphens));
    }
}
Console.WriteLine("{0}@{0}", new string(' ', n - 1));
for (int upper = 1; upper <= n - 2; upper++)
{
    if (upper % 2 == 1)
    {
        Console.WriteLine("{0}/ \\{0}", new string('*', stars));
    }
    if (upper % 2 == 0)
    {
        Console.WriteLine("{0}/ \\{0}", new string('-', hyphens));
    }
}