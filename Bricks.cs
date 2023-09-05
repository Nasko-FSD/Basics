Console.Write("Enter the number of bricks: ");
double x = int.Parse(Console.ReadLine());
Console.Write("Enter the number of workers: ");
double w = int.Parse(Console.ReadLine());
Console.Write("Enter the volume of the trunk: ");
double m = int.Parse(Console.ReadLine());
double calculations = (x / (w * m));
Console.WriteLine("The amount of courses needed are:{0}", Math.Ceiling(calculations));