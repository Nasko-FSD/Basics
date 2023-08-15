Console.Write("Enter a number from how many stars you want to draw a Christmas Three: ");
var n = int.Parse(Console.ReadLine());
for (int row = 0; row <= n; row++)
{
    for (int col = 1; col <= n - row; col++)
    {
        Console.Write(" ");
    }
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*");
    }
        Console.Write(" | ");
    for (int col = 1; col <= row; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}