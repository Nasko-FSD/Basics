var firstend = int.Parse(Console.ReadLine());
var secondend = int.Parse(Console.ReadLine());
var point = int.Parse(Console.ReadLine());
var left = Math.Min(firstend, secondend);
var right = Math.Max(firstend, secondend);
if (point >= left && point <= right)
{
    Console.WriteLine("in");
    var closertoleft = point - left;
    var closertoright = right - point;
    Console.WriteLine(Math.Min(closertoleft, closertoright));
}
else
{
    Console.WriteLine("out");
    var closertoleft = left - point;
    var closertoright = point - right;
    Console.WriteLine(Math.Max(closertoleft, closertoright));
}