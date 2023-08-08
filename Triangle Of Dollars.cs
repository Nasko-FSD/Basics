Console.Write("Enter a triangle of how many $ you want to draw: ");
var n = int.Parse(Console.ReadLine());
for (int row = 1; row <= n; row++)
{
    Console.Write("$");
    for (int col = 1; col < row; col++)
    {
        Console.Write(" $");
    }
    Console.WriteLine();
}