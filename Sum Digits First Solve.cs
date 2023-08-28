Console.Write("Enter the number which digits you want to sum: ");
var n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
var sum = 0;
do
{
    sum = sum + n % 10;
    n = n / 10;
} while (n > 0);
Console.WriteLine("The sum of digits is: {0}", sum);