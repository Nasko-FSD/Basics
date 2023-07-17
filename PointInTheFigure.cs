Console.Write("Enter the value of h: ");
double h = double.Parse(Console.ReadLine());
Console.Write("Enter the value of x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Enter the value of y: ");
double y = double.Parse(Console.ReadLine());
var x1 = 0;
var y1 = 0;
var x2 = 3 * h;
var y2 = h;
var x3 = h;
var y3 = h;
var x4 = 2 * h;
var y4 = 4 * h;
var insideRectangle1 = (x > x1 && x < x2) && (y > y1 && y < y2);
var insideRectangle2 = (x > x3 && x < x4) && (y > y3 && y < y4);
var onleftside = (y == y1) && (x >= x1) && (x <= x2);
var onrightside = (y == y2) && (x >= x1) && (x <= x2);
var onupside = (x == x4) && (y >= y3) && (y <= y4) && (x < x2) && (x > x1);
var ondownside = (x == x1) && (y >= y1) && (y <= y2);
var innermiddle = (x == x3) && (y >= y3) && (y <= y4) && (x < x2) && (x > x1);
var middle = (x == x2) && (y >= y1) && (y <= y2);
var between = (x > x3) && (x < x4) && (y >= y3) && (y < y4);
var onupperrightside = (y == y4) && (x >= x3) && (x <= x4);
if (insideRectangle1 || insideRectangle2 || between)
{
    Console.WriteLine("inside");
}
else if (onleftside || onrightside || onupside || ondownside || innermiddle || middle || onupperrightside)
{
    Console.WriteLine("border");
}
else
{
    Console.WriteLine("outside");
}