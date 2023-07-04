Console.Write("Enter the value on x1: ");
var x1 = double.Parse(Console.ReadLine());
Console.Write("Enter the value on y1: ");
var y1 = double.Parse(Console.ReadLine());
Console.Write("Enter the value on x2: ");
var x2 = double.Parse(Console.ReadLine());
Console.Write("Enter the value on y2: ");
var y2 = double.Parse(Console.ReadLine());
Console.Write("Enter the value on x: ");
var x = double.Parse(Console.ReadLine());
Console.Write("Enter the value on y: ");
var y = double.Parse(Console.ReadLine());
if ( x >= x1 && x <= x2 && y >= y1 && y <= y2)
{
    Console.WriteLine("Inside");
}
else
{
    Console.WriteLine("Outside");
}
