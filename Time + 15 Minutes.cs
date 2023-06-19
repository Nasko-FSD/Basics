Console.Write("Enter hours:");
double hours = double.Parse(Console.ReadLine());
Console.Write("Enter minutes:");
double minutes = double.Parse(Console.ReadLine());
minutes = minutes + 15;
if (minutes >= 60)
{
    minutes = minutes % 60;
    hours++;
}
if (hours >= 24)
{
    hours = hours % 24;
}
if (minutes < 10)
{
    Console.WriteLine("{0}:0{1}", hours, minutes);
}
else if (minutes >= 10)
{
    Console.WriteLine("{0}:{1}", hours, minutes);
}
