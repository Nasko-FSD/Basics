Console.Write("Enter a number for the width on Arrow: ");
var n = int.Parse(Console.ReadLine());
var outerdots = (n - 1) / 2;
var innerdots = n - 2;
var tags = outerdots;
Console.WriteLine("{0}{1}{2}", new string('.', outerdots), new string('#', n), new string('.', outerdots));
for (int row = 1; row < n - 1; row++)
{
    Console.WriteLine("{0}#{1}#{2}", new string('.', outerdots), new string('.', innerdots), new string('.', outerdots));
}
Console.WriteLine("{0}{1}{2}", new string('#', outerdots + 1), new string('.', innerdots), new string('#', outerdots + 1));
outerdots = 1;
innerdots = 2 * n - 5;
for (int col = 1; col < n - 1; col++)
{
    Console.WriteLine("{0}#{1}#{2}", new string('.', outerdots), new string('.', innerdots), new string('.', outerdots));
    outerdots++;
    innerdots -= 2;
}
Console.WriteLine("{0}#{1}", new string('.', outerdots), new string('.', outerdots));