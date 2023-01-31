Console.Write("Enter the length on lab: ");
double length = double.Parse(Console.ReadLine());
Console.Write("Enter the width on lab: ");
double width = double.Parse(Console.ReadLine());
double sumwidth = Math.Truncate((width - 1) / 0.7);
double sumlength = Math.Truncate(length / 1.2);
double seats = (sumwidth * sumlength)-3;
Console.WriteLine("The number of seats are: " + seats);