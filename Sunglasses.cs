Console.Write("Enter a number for how big Sunglasses you want to draw: ");
var n = int.Parse(Console.ReadLine());
for (int row = 0; row < n; row++)
{
    Console.Write("*");
    if (row == 0 || row == n - 1)
    {
        Console.Write(new string('*', n * 2 - 1));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
    }
    else
    {
        Console.Write(new string('/', n * 2 - 2));
        Console.Write("*");
        if (( n % 2 == 1) && (row == (n-1)/2))
        {
            Console.Write(new string('|', n));
        }
        else if ((n % 2 == 0) && (row == n / 2 - 1))
        {
            Console.Write(new string('|', n));
        }
        else
        {
            Console.Write(new string(' ', n));
        }
        Console.Write("*");
        Console.Write(new string('/', n * 2 - 2));
        Console.WriteLine("*");
    }
}