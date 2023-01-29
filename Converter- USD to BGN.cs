Console.Write("Enter the amount in USD: ");
double USD = double.Parse(Console.ReadLine());
double sum = USD * 1.79549;
Console.WriteLine("The amount in BGN is: " + Math.Round(sum, 2));