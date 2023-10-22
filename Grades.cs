var students = int.Parse(Console.ReadLine());
double fail = 0;
double good = 0;
double verygood = 0;
double excellent = 0;
double average = 0;
double prevgrade = 0;
for (double kids = 1; kids <= students; kids++)
{
    double grades = double.Parse(Console.ReadLine());
    if (grades >= 2 && grades < 3)
    {
        fail++;
    }
    if (grades >= 3 && grades < 4)
    {
        good++;
    }
    if (grades >= 4 && grades < 5)
    {
        verygood++;
    }
    if (grades >= 5 && grades <= 6)
    {
        excellent++;
    }
    prevgrade += grades;
    average = prevgrade / students;
}
Console.WriteLine("Top students: {0:f2}%", (excellent * 100) / students);
Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (verygood * 100) / students);
Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (good * 100) / students);
Console.WriteLine("Fail: {0:f2}%", (fail * 100) / students);
Console.WriteLine("Average: {0:f2}", average);