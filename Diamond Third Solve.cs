int n = int.Parse(Console.ReadLine());
var leftRighthyphens = (n - 1) / 2;
for (int i = 1; i <= (n - 1) / 2; i++)
{
    Console.Write(new string('-', leftRighthyphens));
    Console.Write("*");
    var midhyphens = n - 2 * leftRighthyphens - 2;
    if (midhyphens >= 0)
    {
        Console.Write(new string('-', midhyphens));
        Console.Write("*");
    }
    Console.WriteLine(new string('-', leftRighthyphens));
    leftRighthyphens--;
}
for (int j = (n - 1) / 2; j >= 0; j--)
{
    Console.Write(new string('-', leftRighthyphens));
    Console.Write("*");
    var mid = n - 2 * leftRighthyphens - 2;
    if (mid >= 0)
    {
        Console.Write(new string('-', mid));
        Console.Write("*");
    }
    Console.WriteLine(new string('-', leftRighthyphens));
    leftRighthyphens++;
}