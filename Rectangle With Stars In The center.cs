Console.Write("Enter a number to draw a rectangle: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine(new string('%', n * 2));
int numRows = n - 1;
if (n % 2 == 1) numRows++;
for (int row = 0; row < numRows; row++)
{
    Console.Write("%");
    Console.Write(new string(' ', n - 2));
    if (row == (n - 1) / 2)
    {
        Console.Write("**");
    }
    else
    {
        Console.Write("  ");
    }
    Console.Write(new string(' ', n - 2));
    Console.Write("%");
    Console.WriteLine();
}
Console.WriteLine(new string('%', n * 2));