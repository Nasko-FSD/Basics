Console.Write("Enter a number: ");
var number = int.Parse(Console.ReadLine());
var tens = 0;
var ones = 0;
if (number == 0)
{
Console.WriteLine("zero");
}
else if (number == 1)
{
Console.WriteLine("one");
}
else if (number == 1)
{
Console.WriteLine("one");
}
else if (number == 2)
{
    Console.WriteLine("two");
}
else if (number == 3)
{
    Console.WriteLine("three");
}
else if (number == 4)
{
    Console.WriteLine("four");
}
else if (number == 5)
{
    Console.WriteLine("five");
}
else if (number == 6)
{
    Console.WriteLine("six");
}
else if (number == 7)
{
    Console.WriteLine("seven");
}
else if (number == 8)
{
    Console.WriteLine("eight");
}
else if (number == 9)
{
    Console.WriteLine("nine");
}
else if (number == 10)
{
    Console.WriteLine("ten");
}
else if (number == 11)
{
    Console.WriteLine("eleven");
}
else if (number == 12)
{
    Console.WriteLine("twelve");
}
else if (number == 13)
{
    Console.WriteLine("thirteen");
}
else if (number == 14)
{
    Console.WriteLine("fourteen");
}
else if (number == 15)
{
    Console.WriteLine("fifteen");
}
else if (number == 16)
{
    Console.WriteLine("sixteen");
}
else if (number == 17)
{
    Console.WriteLine("seventeen");
}
else if (number == 18)
{
    Console.WriteLine("eighteen");
}
else if (number == 19)
{
    Console.WriteLine("nineteen");
}
else if (number >=20 && number <= 99)
{
    tens = number / 10;
    ones = number % 10;
}
if (tens == 2)
{
    Console.Write("twenty");
}
if (tens == 3)
{
    Console.Write("thirty");
}
if (tens == 4)
{
    Console.Write("forty");
}
if (tens == 5)
{
    Console.Write("fifty");
}
if (tens == 6)
{
    Console.Write("sixty");
}
if (tens == 7)
{
    Console.Write("seventy");
}
if (tens == 8)
{
    Console.Write("eighty");
}
if (tens == 9)
{
    Console.Write("ninety");
}
if (ones == 1)
{
    Console.Write(" one");
}
if (ones == 2)
{
    Console.Write(" two");
}
if (ones == 3)
{
    Console.Write(" three");
}
if (ones == 4)
{
    Console.Write(" four");
}
if (ones == 5)
{
    Console.Write(" five");
}
if (ones == 6)
{
    Console.Write(" six");
}
if (ones == 7)
{
    Console.Write(" seven");
}
if (ones == 8)
{
    Console.Write(" eight");
}
if (ones == 9)
{
    Console.Write(" nine");
}
if (number == 100)
{
    Console.WriteLine("one hundred");
}
else if (number > 100)
        {
    Console.WriteLine("invalid number");
}
else if ( number < 0)
        {
    Console.WriteLine("invalid number");
}