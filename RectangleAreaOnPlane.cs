Console.WriteLine("Enter the side of the Rectangle: x1= ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the side of the Rectangle: y1= ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the side of the Rectangle: x2= ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the side of the Rectangle: y2= ");
double y2 = double.Parse(Console.ReadLine());
double width = Math.Max(x1, x2) - Math.Min(x1, x2);
double height = Math.Max(y1, y2) - Math.Min(y1, y2);
double area = width * height;
double perimeter = 2 * (width + height);
Console.WriteLine("Area = " + area);
Console.WriteLine("Perimeter = " + perimeter);


