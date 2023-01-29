Console.Write("Enter the angle in Radians: ");
double radians = double.Parse(Console.ReadLine());
double sum = radians * 180 / Math.PI;
Console.WriteLine("The angle in Degrees is: " + Math.Round(sum));