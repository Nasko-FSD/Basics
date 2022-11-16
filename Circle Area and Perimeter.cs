Console.Write("Enter circle radius. r = ");
var radius = double.Parse(Console.ReadLine());
var area = Math.PI * radius * radius;
var perimeter = 2 * Math.PI * radius; 
Console.WriteLine("Circle Area = " + area);
Console.WriteLine("Circle Perimeter = " + perimeter);