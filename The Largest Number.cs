Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Enter {0} numbers: ", n);
var max = int.Parse(Console.ReadLine());
for (int i = 1; i <= n-1; i++)
{
    Console.Write("nume {0}= ", i);
    var num = int.Parse(Console.ReadLine());
    if (num > max)
    {
        max = num;
    }
}
Console.WriteLine("The largest number is: " + max);