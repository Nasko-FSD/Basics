Console.Write("Enter side size of floor: ");
double floorsize = double.Parse(Console.ReadLine());
Console.Write("Enter the width of tile: ");
double tilewidth = double.Parse(Console.ReadLine());
Console.Write("Enter the length of tile: ");
double tilelength = double.Parse(Console.ReadLine());
Console.Write("Enter the width of bench: ");
double benchwidth = double.Parse(Console.ReadLine());
Console.Write("Enter the length of bench: ");
double benchlength = double.Parse(Console.ReadLine());
double sum = ((floorsize * floorsize) - (benchwidth * benchlength)) / (tilewidth * tilelength);
Console.WriteLine("The required tiles are: " + Math.Round(sum, 2));
double time = sum * 0.2;
Console.WriteLine("The amount of time required for repair is: " + Math.Round(time, 2));



