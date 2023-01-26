Console.Write("Enter Side of the Triangle: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enter the Height of the Triangle: ");
double h = double.Parse(Console.ReadLine());
double area = a * h / 2;
Console.WriteLine("Triangle area is: " + Math.Round(area, 2));
