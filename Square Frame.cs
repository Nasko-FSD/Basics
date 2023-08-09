Console.Write("Enter a Square Frame from how many n*n signs you want to draw: ");
var n = int.Parse(Console.ReadLine());
Console.Write("+");
for (int row = 1; row < n - 1; row++)
{
    Console.Write(" -");
}
Console.WriteLine(" +");
for (int col = 1; col < n - 1; col++)
{
    Console.Write("|");
    for (int row = 1; row < n - 1; row++)
    {
        Console.Write(" -");
    }
    Console.WriteLine(" |");
}
Console.Write("+");
for (int row = 1; row < n - 1; row++)
{
    Console.Write(" -");
}
Console.Write(" +");