var n = int.Parse(Console.ReadLine());
for (int row = 1; row <= n; row++)
{
    for (int spaces = 1; spaces <= n - row; spaces++)
    {
        Console.Write(" ");
    }
    for (int stars = 1; stars <= row; stars++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
for (int row = 1; row <= n - 1; row++)
{
    for (int spaces = 1; spaces <= row; spaces++)
    {
        Console.Write(" ");
    }
    for (int stars = 1; stars <= n - row; stars++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}