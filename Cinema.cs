Console.Write("Enter the type of projection: ");
var projection = (Console.ReadLine()).ToLower();
Console.Write("Enter the number of rows: ");
var rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
var columns = int.Parse(Console.ReadLine());
double premiere = 12;
double normal = 7.50;
double discount = 5;
if (projection == "premiere")
{
    Console.WriteLine("{0:f2}", premiere * (rows * columns));
}
else if (projection == "normal")
{
    Console.WriteLine("{0:f2}", normal * (rows * columns));
}
else if (projection == "discount")
{
    Console.WriteLine("{0:f2}", discount * (rows * columns));
}
