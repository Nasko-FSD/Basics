Console.Write("Enter first number: ");
var firstEnd = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
var secondEnd = int.Parse(Console.ReadLine());
Console.Write("Enter the point: ");
var point = int.Parse(Console.ReadLine());
var left = Math.Min(firstEnd, secondEnd);
var right = Math.Max(firstEnd, secondEnd);
var pointOnSegment = (point >= left && point <= right);
var leftDistance = Math.Abs(point - left);
var rightDistance = Math.Abs(point - right);
var distance = Math.Min(leftDistance, rightDistance);
if (pointOnSegment)
{
    Console.WriteLine("in");
}
else
{
    Console.WriteLine("out");
}
Console.WriteLine(distance);