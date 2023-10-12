var n = int.Parse(Console.ReadLine());
Console.Write(new string('*', n * 2));
Console.Write(new string(' ', n));
Console.WriteLine(new string('*', n * 2));
for (int row = 1; row <= n - 2; row++)
{
    Console.Write('*');
    for (int slash = 1; slash <= (n * 2) - 2; slash++)
    {
        Console.Write("/");
    }
    Console.Write('*');
    if (row == (n - 1) / 2)
    {
        Console.Write(new string('|', n));
    }
    else
    {
        Console.Write(new string(' ', n));
    }
    Console.Write('*');
    for (int slash = 1; slash <= (n * 2) - 2; slash++)
    {
        Console.Write("/");
    }
    Console.WriteLine('*');
}
Console.Write(new string('*', n * 2));
Console.Write(new string(' ', n));
Console.Write(new string('*', n * 2));