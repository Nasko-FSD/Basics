Console.Write("Enter the type of year: leap = 366 days / normal = 365 days: ");
var year = (Console.ReadLine()).ToLower();
Console.Write("Enter the number of holidays that aren't Saturdays or Sundays: ");
double holidays = double.Parse(Console.ReadLine());
Console.Write("Enter the number of weekends on which Vladi travels to his home town: ");
double weekendsHome = double.Parse(Console.ReadLine());
double playholidays = holidays * (2.0/3);
double playweekends = (48 - weekendsHome) * (3.0/4);
double totalgames = playholidays + weekendsHome + playweekends;
if ( year == "leap")
{
    totalgames += totalgames * 0.15;
    Console.WriteLine(Math.Floor(totalgames));
}
else if ( year == "normal")
{
    Console.WriteLine(Math.Floor(totalgames));
}