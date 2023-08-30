Console.Write("Enter Even number: ");
var n = 0;
while (true)
{
    try
    {
        n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            break;
        }
        Console.WriteLine("The number is not even.");
    }
    catch
    {
        Console.WriteLine("This is not a number");
    }
}
Console.WriteLine("Even number entered: {0}", n);