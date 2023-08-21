var n = int.Parse(Console.ReadLine());
var lowercase = (n * 2) - 1;
Console.WriteLine("{0}{1}{2}", new string('.', n + 1), new string('_', (n * 2) + 1), new string('.', n + 1));
for (int row = 1; row <= n; row++)
{
    var dots = n - (row - 1);
    Console.WriteLine("{0}//{1}\\\\{2}", new string('.', dots), new string('_', lowercase), new string('.', dots));
    lowercase = lowercase + 2;
}
Console.WriteLine("//{0}STOP!{1}\\\\", new string('_', (lowercase - 5) / 2), new string('_', (lowercase - 5) / 2));
Console.WriteLine("\\\\{0}//", new string('_', lowercase));
var point = 1;
for (int row = 1; row <= n - 1; row++)
{
    Console.WriteLine("{0}\\\\{1}//{2}", new string('.', point), new string('_', lowercase - 2), new string('.', point));
    lowercase = lowercase - 2;
    point++;
}