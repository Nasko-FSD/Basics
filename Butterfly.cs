var n = int.Parse(Console.ReadLine());
var halfrowsize = n - 2;
var halfbody = n - 1;
for (int row = 1; row <= n - 2; row++)
{
    if (row % 2 != 0)
    {
        Console.WriteLine("{0}\\ /{1}", new string('*', halfrowsize), new string('*', halfrowsize));
    }
    if (row % 2 == 0)
    {
        Console.WriteLine("{0}\\ /{1}", new string('-', halfrowsize), new string('-', halfrowsize));
    }
}
    Console.WriteLine("{0}@{1}", new string(' ', halfbody), new string(' ', halfbody));
for (int col = 1; col <= n - 2; col++)
{
    if (col % 2 != 0)
    {
        Console.WriteLine("{0}/ \\{1}", new string('*', halfrowsize), new string('*', halfrowsize));
    }
    if (col % 2 == 0)
    {
        Console.WriteLine("{0}/ \\{1}", new string('-', halfrowsize), new string('-', halfrowsize));
    }
}