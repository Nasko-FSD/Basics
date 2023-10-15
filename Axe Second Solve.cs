var n = int.Parse(Console.ReadLine());
var lefthyphens = 3 * n;
var innerhypens = 1;
var righthyphens = ((5 * n) - (3 * n) - 2);
Console.WriteLine("{0}**{1}", new string('-', lefthyphens), new string('-', righthyphens));
//righthyphens = ((5 * n) - (3 * n) - 2 - innerhypens);
for (int uprows = 1; uprows <= n - 1; uprows++)
{
    righthyphens = ((5 * n) - (3 * n) - 2 - innerhypens);
    Console.WriteLine("{0}*{1}*{2}", new string('-', lefthyphens), new string('-', innerhypens),
        new string('-', righthyphens));
    innerhypens++;
}
for (int handle = 1; handle <= n / 2; handle++)
{
    innerhypens = n - 1;
    var stars = 3 * n;
    Console.WriteLine("{0}*{1}*{2}", new string('*', stars), new string('-', innerhypens),
        new string('-', righthyphens));
}
for (int lower = 1; lower <= (n - 2) / 2; lower++)
{
    Console.WriteLine("{0}*{1}*{2}", new string('-', lefthyphens), new string('-', innerhypens),
        new string('-', righthyphens));
    lefthyphens--;
    innerhypens += 2;
    righthyphens--;
}
Console.WriteLine("{0}*{1}*{2}", new string('-', lefthyphens), new string('*', innerhypens),
    new string('-', righthyphens));