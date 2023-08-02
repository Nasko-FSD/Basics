Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter {0} numbers: ", n);
var sum = 0;
var max = int.MinValue;
for (int i = 1; i <= n; i++)
{
    Console.Write("num {0}= ", i);
    var num = int.Parse(Console.ReadLine());
    if (num > max)
    {
        max = num;
    }
    sum = sum + num;
}
sum = sum - max;
if (sum == max)
    {
        Console.WriteLine("Yes, sum = " + sum);
    }
    else
    {
        var diff = Math.Abs(sum - max);
        Console.WriteLine("No, diff = " + diff);
    }