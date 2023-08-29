Console.Write("Enter a number to check if it's Prime or not: ");
var n = long.Parse(Console.ReadLine());
var prime = (n > 1);
for (var i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        prime = false;
        break;
    }
}
if (prime)
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Not Prime");
}
