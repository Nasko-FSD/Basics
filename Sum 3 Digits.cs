Console.Write("Enter 3 numbers: ");
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
var num3 = int.Parse(Console.ReadLine());
var min  = Math.Min(Math.Min(num1, num2), num3);
var max = Math.Max(Math.Max(num1, num2), num3);
var sum = num1 + num2 + num3;
var mid = sum - min - max;
if (min + mid == max)
{
    Console.WriteLine("{0} + {1} = {2}", min, mid, max);
}
else
{
    Console.WriteLine("No");
}