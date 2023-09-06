Console.Write("Enter the day from 1 to 7: ");
var day = int.Parse(Console.ReadLine());
Console.Write("Enter the month from 01 to 12: ");
var month = int.Parse(Console.ReadLine());
var daysinTheMonth = 31;
if (month == 04 || month == 06 || month == 09 || month == 11)
{
    daysinTheMonth = 30;
}
else if (month == 02)
{
    daysinTheMonth = 28;
}
day = day + 5;
if (day > daysinTheMonth)
{
    day = day - daysinTheMonth;
    month++;
}
if (month > 12)
{
    month = 01;
}
if (month < 10)
{
    Console.WriteLine("{0}.0{1}", day, month);
}
else
{
    Console.WriteLine("{0}.{1}", day, month);
}