Console.Write("Enter the type of figure:");
string type = (Console.ReadLine());
if (type == "square")
{
    Console.Write("Enter the side:");
    double side = double.Parse(Console.ReadLine());
    var areaofsquare = side * side;
    Console.WriteLine("The area of triangle is: " + Math.Round(areaofsquare, 3));
}

else if ( type == "rectangle")
{
    Console.Write("Enter the length of rectangle:");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Enter the width:");
    double width = double.Parse(Console.ReadLine());
    var areaofrectangle = length * width;
    Console.WriteLine("The area of rectangle is: " + Math.Round(areaofrectangle, 3));
}

else if ( type == "circle")
{
    Console.Write("Enter the radius");
    double radius = double.Parse(Console.ReadLine());
    var areaofcircle = (radius * radius) * Math.PI;
    Console.WriteLine("The area of circle is: " + Math.Round(areaofcircle, 3));
}

else if ( type == "triangle")
{
    Console.Write("Enter the side:");
    double lengthoftriangle = double.Parse(Console.ReadLine());
    Console.Write("Enter the height:");
    double height = double.Parse(Console.ReadLine());
    var areaoftriangle = (lengthoftriangle * height) / 2;
    Console.WriteLine("The area of triangle is: " + Math.Round(areaoftriangle, 3));
}
