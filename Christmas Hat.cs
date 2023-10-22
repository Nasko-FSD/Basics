var n = int.Parse(Console.ReadLine());
var dots = (n * 2) - 1;
var previous = n * 2;
Console.WriteLine("{0}/|\\{0}", new string('.', dots));
Console.WriteLine("{0}\\|/{0}", new string('.', dots));
Console.WriteLine("{0}***{0}", new string('.', dots));
for (int rows = 1; rows <= (n * 2) - 1; rows++)
{
    var hyphens = rows;
    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dots - 1), new string('-', hyphens));
    dots--;
}
Console.WriteLine(new string('*', (n * 4) + 1));
for (int last = 1; last <= n * 2; last++)
{
    Console.Write("*.", previous);
}
Console.WriteLine("*");
Console.WriteLine(new string('*', (n * 4) + 1));