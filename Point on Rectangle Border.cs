Console.Write("Enter the coordinates on x1: ");
var x1 = double.Parse(Console.ReadLine());
Console.Write("Enter the coordinates on y1: ");
var y1 = double.Parse(Console.ReadLine());
Console.Write("Enter the coordinates on x2: ");
var x2 = double.Parse(Console.ReadLine());
Console.Write("Enter the coordinates on y2: ");
var y2 = double.Parse(Console.ReadLine());
Console.Write("Enter the coordinates on x: ");
var x = double.Parse(Console.ReadLine());
Console.Write("Enter the coordinates on y: ");
var y = double.Parse(Console.ReadLine());
var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
var onUpperSide = (y == y1) && (x >= x1) && (x <= x2);
var onLowerSide = (y == y2) && (x >= x1) && (x <= x2);
if (onLeftSide || onRightSide || onUpperSide || onLowerSide)
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside / Outside");
}