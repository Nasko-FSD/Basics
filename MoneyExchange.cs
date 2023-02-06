Console.Write("Enter the amount of Bitcoin: ");
double bitcoin = double.Parse(Console.ReadLine());
Console.Write("Enter the amount of Chinese Yuan: ");
double cny = double.Parse(Console.ReadLine());
Console.Write("Enter the amount of Commission: ");
double commission = double.Parse(Console.ReadLine()) / 100.00;
double euro = (bitcoin * 1168 + cny * 0.15 * 1.76) / 1.95;
double eurocommission = euro - (commission * euro);
Console.WriteLine("The amount in Euro is: " + eurocommission);