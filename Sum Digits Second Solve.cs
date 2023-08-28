Console.Write("Enter the number which digits you want to sum: ");
var n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
var sum = 0;
while (n > 0)
{
    var digit = n % 10;
    sum = sum + digit;
    n = n / 10;
}
Console.WriteLine("The sum of digits is: {0}", sum);