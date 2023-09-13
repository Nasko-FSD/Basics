Console.Write("Enter a number to draw a perfect diamond: ");
var n = int.Parse(Console.ReadLine());
for (int row = 1; row <= n; row++)
{
    Console.Write(new string(' ', n - row));
    Console.Write("*");
    for (int col = 1; col < row; col++)
    {
        Console.Write("-*");
    }
    Console.WriteLine();
}
for (int row = 1; row < n; row++)
{
    Console.Write(new string(' ', row));
    Console.Write("*");
    for (int col = 2; col <= n - row; col++)
    {
        Console.Write("-*");
    }
    Console.WriteLine();
}