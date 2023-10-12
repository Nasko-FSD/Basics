var n = int.Parse(Console.ReadLine());
for (int row = 0; row <= n; row++)
{
    for (int spaces = 1; spaces <= n - row; spaces++)
    {
        Console.Write(" ");
    }
    Console.Write(new string('*', row));
    Console.Write(" | ");
    Console.Write(new string('*', row));
    Console.WriteLine();
}