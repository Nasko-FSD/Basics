Console.Write("Enter a number: ");
var n = int.Parse(Console.ReadLine());
for (int row = 0; row < n; row++)
{
    for (int col = 1; col <= n; col++)
    {
        var num = (col + row);
        if (num > n)
        {
            num = -num + 2 * n;
        }
        if (col > 1)
        {
            Console.Write(" ");
        }
        Console.Write(num);        
    }
    Console.WriteLine();
}