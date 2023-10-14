var n = int.Parse(Console.ReadLine());
var upper = n / 2;
var mid = 2 * n - 2 * upper - 4;
Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', upper), new string('_', mid));
for (int body = 1; body <= n - 3; body++)
{
    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
}
Console.WriteLine("|{0}{1}{0}|", new string(' ', upper + 1), new string('_', mid));
Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', upper), new string(' ', mid));