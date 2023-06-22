Console.Write("Enter the Project Hours: ");
var projectHours = int.Parse(Console.ReadLine());
Console.Write("Enter the Available Days: ");
var availableDays = int.Parse(Console.ReadLine());
Console.Write("Enter the number of Workers: ");
var overtimeWorkers = int.Parse(Console.ReadLine());
double workdays = availableDays * 0.9;
double overtimeHours = overtimeWorkers * 2 * workdays;
double workHours = workdays * 8 * overtimeWorkers;
double totalHours = Math.Floor(workHours + overtimeHours);
if (totalHours >= projectHours)
{
    Console.WriteLine("Yes!{0} hours left.", totalHours - projectHours);
}
else
{
    Console.WriteLine("Not enough time!{0} hours needed.", projectHours - totalHours);
}