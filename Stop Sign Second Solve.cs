var n = int.Parse(Console.ReadLine());
var dots = n + 1;
var lower = n * 2 + 1;
Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', lower));
dots = n;
lower -= 2;
for (int row = 1; row <= n; row++)
{
    Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', lower));
    dots--;
    lower += 2;
}
Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (lower - 5) / 2));
Console.WriteLine("\\\\{0}//", new string('_', lower));
dots = 1;
lower -= 2;
for (int lowerpart = 1; lowerpart < n; lowerpart++)
{
    Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', lower));
    lower -= 2;
    dots++;
}