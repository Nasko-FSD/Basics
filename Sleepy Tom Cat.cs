Console.Write("Enter the number of holidays: ");
var holidays = int.Parse(Console.ReadLine());
var workingdays = 365 - holidays;
var totalPlayMinutes = workingdays * 63 + holidays * 127;
var difference = Math.Abs(totalPlayMinutes - 30000);
var hours = difference / 60;
var minutes = difference % 60;
if (totalPlayMinutes > 30000)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
}