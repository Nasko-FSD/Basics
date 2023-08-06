Console.Write("Enter rectangle from how many stars you want to draw: ");
var n = int.Parse(Console.ReadLine());
for ( int row = 1; row <= n; row++)
{
    for (int col = 1; col <= n; col++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
} 