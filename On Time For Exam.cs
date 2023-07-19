Console.Write("Enter the Exam hour: ");
var examHour = int.Parse(Console.ReadLine());
Console.Write("Enter the Exam minutes: ");
var examMinutes = int.Parse(Console.ReadLine());
Console.Write("Enter the arrival hour: ");
var arrivalHour = int.Parse(Console.ReadLine());
Console.Write("Enter the arrival minutes: ");
var arrivalMinutes = int.Parse(Console.ReadLine());
decimal totalExamTime = (examHour * 60) + examMinutes;
decimal totalArrivalTime = (arrivalHour * 60) + arrivalMinutes;
decimal totalDifferenceTime = Math.Abs(totalExamTime - totalArrivalTime);
decimal totalDifferenceHour = Math.Floor(totalDifferenceTime / 60);
decimal totalDifferenceMinutes = totalDifferenceTime % 60;
if (totalExamTime == totalArrivalTime)
{
    Console.WriteLine("On time");
}
else if (totalExamTime < totalArrivalTime)
{
    {
        Console.WriteLine("Late");
    }
    if (totalDifferenceTime < 60)
    {
        Console.WriteLine("{0} minutes after the start", totalDifferenceTime);
    }
    else if (totalDifferenceMinutes < 10)
    {
        Console.WriteLine("{0}:0{1} hours after the start", totalDifferenceHour, totalDifferenceMinutes);
    }
    else
    {
        Console.WriteLine("{0}:{1} hours after the start", totalDifferenceHour, totalDifferenceMinutes);
    }
}
else
{
    if (totalDifferenceTime <= 30)
    {
        Console.WriteLine("On time");
        Console.WriteLine("{0} minutes before the start", totalDifferenceMinutes);
    }
    else
    {
        Console.WriteLine("Early");
        if (totalDifferenceTime < 60)
        {
            Console.WriteLine("{0} minutes before the start", totalDifferenceTime);
        }
        else if (totalDifferenceMinutes < 10)
        {
            Console.WriteLine("{0}:0{1} hours before the start", totalDifferenceHour, totalDifferenceMinutes);
        }
        else
        {
            Console.WriteLine("{0}:{1} hours before the start", totalDifferenceHour, totalDifferenceMinutes);
        }
    }
}