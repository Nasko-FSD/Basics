var period = int.Parse(Console.ReadLine());
var treated = 0;
var untreated = 0;
var doctors = 7;
for (int day = 1; day <= period; day++)
{
    var patients = int.Parse(Console.ReadLine());
    if (day % 3 == 0 && untreated > Math.Abs(treated))
    {
        doctors++;
    }
    if (doctors - patients >= 0)
    {
        if (doctors - patients > 0)
        {
            treated += patients;
        }
        if (doctors - patients == 0)
        {
            treated += doctors;
        }
    }
    if (doctors - patients < 0)
    {
        treated += doctors;
        untreated += Math.Abs(patients - doctors);
    }
}
Console.WriteLine("Treated patients: {0}.", treated);
Console.WriteLine("Untreated patients: {0}.", untreated);