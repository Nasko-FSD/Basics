Console.Write("Enter a Square From from how many n*n symbols you want to draw: ");
var n = int.Parse(Console.ReadLine());
for (int row = 0; row < n; row++)
{
    if(row == 0 || row == n - 1)
    {
        Console.Write("+");
    }
    else
    {
        Console.Write("|");
    }
    for (int col = 0; col < n - 2; col++)        
    {
            Console.Write(" -");
    }
    if (row == 0 || row == n - 1)
    {
        Console.Write(" +");
    }
    else
    {
        Console.Write(" |");
    } 
    Console.WriteLine();
}