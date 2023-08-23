Console.Write("Enter a number in range from 1 to 100: ");
var number = int.Parse(Console.ReadLine());
while (number < 1 || number > 100)
{
    Console.WriteLine("Invalid number!");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine("The number is: {0}", number);