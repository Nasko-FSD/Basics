Console.Write("Enter hours:");
double hours = double.Parse(Console.ReadLine());
Console.Write("Enter minutes:");
double minutes = double.Parse(Console.ReadLine());
minutes = minutes + 15;
if (minutes >= 60)
{
minutes = minutes - 60;
hours++;
}
else if (hours > 23)
{
hours = hours - 24;
}
if (hours == 24)
{
hours = hours - 24;
}
if (minutes < 10)
{
Console.WriteLine(hours + ":0" + minutes);
}
else if (minutes >= 10)
{
Console.WriteLine(hours + ":" + minutes);
}