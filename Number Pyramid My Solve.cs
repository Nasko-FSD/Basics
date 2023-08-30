Console.Write("Enter a number: ");
var n = int.Parse(Console.ReadLine());
var num = 1;
for (int row = 1; row <= n; row++)
{
    for (int col = 1; col <= row; col++)
    {
        if (col > 1)
        {
            Console.Write(" ");
        }
        if (num >= n + 1)
        {
            break;
        }
        Console.Write(num);
        num++;
    }
    Console.WriteLine();
}