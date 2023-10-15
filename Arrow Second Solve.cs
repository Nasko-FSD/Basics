var n = int.Parse(Console.ReadLine());
var outerdots = n / 2;
var tags = n;
var innerdots = n - 2;
Console.WriteLine("{0}{1}{0}", new string('.', outerdots), new string('#', tags));
for (int uprows = 1; uprows <= n - 2; uprows++)
{
    Console.WriteLine("{0}#{1}#{0}", new string('.', outerdots), new string('.', innerdots));
}
tags = (n + 1) / 2;
Console.WriteLine("{0}{1}{0}", new string('#', tags), new string('.', innerdots));
outerdots = 1;
innerdots = (n * 2) - 5;
for (int lowrows = 1; lowrows <= n - 2; lowrows++)
{
    Console.WriteLine("{0}#{1}#{0}", new string('.', outerdots), new string('.', innerdots));
    outerdots++;
    innerdots -= 2;
}
Console.WriteLine("{0}#{0}", new string('.', outerdots));