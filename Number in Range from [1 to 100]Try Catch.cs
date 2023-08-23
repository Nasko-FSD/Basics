var n = -1;
while (true)
{
    try
    {
        n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 100)
        {
            break;
        }
        Console.WriteLine("Invalid Number!");
    }
    catch
    {
        Console.WriteLine("This is not a number!");
    }
}
Console.WriteLine("The number is: " + n);