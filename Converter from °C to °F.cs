Console.Write("Enter temperature °C: ");
double C = double.Parse(Console.ReadLine());
double sum = (C * 9/5) + 32;
Console.WriteLine("Temperature in °F is: " + Math.Round(sum, 2));