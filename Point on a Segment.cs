var firstend = int.Parse(Console.ReadLine());
var secondend = int.Parse(Console.ReadLine());
var point = int.Parse(Console.ReadLine());
var result = 0;
var left = Math.Min(firstend, secondend);
var right = Math.Max(firstend, secondend);
if (point < left || point > right)
{
    if (point - left < right - point)
    {
        result = left - point;
        Console.WriteLine("out");
        Console.WriteLine(Math.Abs(result));
    }
    else
    {
        result = point - right;
        Console.WriteLine("out");
        Console.WriteLine(Math.Abs(result));
    }
}
else if (point >= left && point <= right)
{
    if (point - left < right - point )
    {
        result = point - left;
        Console.WriteLine("in");
        Console.WriteLine(Math.Abs(result));
    }
    else
    {
        result = right - point;
        Console.WriteLine("in");
        Console.WriteLine(Math.Abs(result));
    }
}