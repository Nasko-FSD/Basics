Console.Write("Enter number which reference is a day of week: ");
var day = (Console.ReadLine());
if (day == "1")
{
    Console.WriteLine("Monday");
}
else if (day == "2")
{
    Console.WriteLine("Tuesday");
}
else if (day == "3")
{
    Console.WriteLine("Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("Thursday");
}
else if (day == "5")
{
    Console.WriteLine("Friday");
}
else if (day == "6")
{
    Console.WriteLine("Saturday");
}
else if (day == "7")
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Invalid day!");
}