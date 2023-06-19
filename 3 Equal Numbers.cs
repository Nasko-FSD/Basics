Console.Write("Enter your first number: ");
var number1 = int.Parse(Console.ReadLine());
Console.Write("Enter your second number: ");
var number2 = int.Parse(Console.ReadLine());
Console.Write("Enter your third number: ");
var number3 = int.Parse(Console.ReadLine());
if (number1 == number2 && number2 == number3)
{
    Console.WriteLine("yes");
}
if (number1 != number2 && number1 != number3)
{
    Console.WriteLine("no");
}
else if ( number2 != number3)
{
    Console.WriteLine("no");
}