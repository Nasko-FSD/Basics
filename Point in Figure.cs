var x1 = 2;
var y1 = -3;
var x2 = 12;
var y2 = 1;
var x3 = 4;
var y3 = -5;
var x4 = 10;
var y4 = 3;
var pointX = int.Parse(Console.ReadLine());
var pointY = int.Parse(Console.ReadLine());
var PointinfirtsRectangle = (pointX >= x1 && pointX <= x2) && (pointY >= y1 && pointY <= y2);
var PointinSecondRectangle = (pointX >= x3 && pointX <= x4) && (pointY >= y3 && pointY <= y4);
var PointInRectangles = PointinfirtsRectangle || PointinSecondRectangle;
if (PointInRectangles)
{
    Console.WriteLine("in");
}
else
{
    Console.WriteLine("out");
}