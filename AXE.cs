var n = int.Parse(Console.ReadLine());
var width = 5 * n;
var leftDashes = 3 * n;
var middleDashes = 0;
var rightWidth = width - leftDashes - middleDashes - 2;
for(int upper = 0; upper < n; upper++)
{
    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightWidth));
    middleDashes += 1;
    rightWidth -= 1;
}
middleDashes = n - 1;
for (int mid = 1; mid <= (n / 2); mid++)
{
    Console.WriteLine("{0}*{1}*{2}", new string('*', leftDashes), new string('-', middleDashes), new string('-', rightWidth + 1));
}
middleDashes = n - 1;
for (int lower = 1; lower <= n / 2 - 1; lower++)
{
    Console.WriteLine("{0}*{1}*{2}", new string('-', leftDashes), new string('-', middleDashes), new string('-', rightWidth + 1));
    leftDashes -= 1;
    middleDashes += 2;
    rightWidth -= 1;
}
Console.WriteLine("{0}{1}{2}", new string('-', leftDashes), new string('*', middleDashes + 2), new string('-', rightWidth + 1));