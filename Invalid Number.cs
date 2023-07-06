Console.Write("Enter a number: ");
var number = double.Parse(Console.ReadLine());
var inRange = (number >= 100 && number <= 200);
var zero = (number == 0);
var valid = inRange || zero;
if (!valid)
{
    Console.WriteLine("invalid");
}
